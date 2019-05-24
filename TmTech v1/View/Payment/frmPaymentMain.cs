using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmPaymentMain : UserControl
    {
        IList<Payment> lstp = new List<Payment>();
        IList<Company> lstcom = new List<Company>();
        IList<Po> lstpo = new List<Po>();
        
        public frmPaymentMain()
        {
            InitializeComponent();
        }

        private void frmPaymentMain_Load(object sender, EventArgs e)
        {
            labelNotify1.Text = "";
            LoadScene();
        }

        private void LoadScene()
        {
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstp = uow.PaymentRepository.All();
                lstcom = uow.CompanyRepository.All();
                //lstpo = uow.PoRepository.All();
                uow.Commit();
            }
            InsertToTreeList(lstp, lstcom, lstpo);
        }

        #region Nodes
        private object CreateObject(int level, Payment s, Po p, Company com)
        {
            object obj;
            if (level == 0) //Company
            {
                if (com == null)
                    return null;
                obj = new object[]
                    {
                        null,//s.PaymentId,//id
                        null,//s.PaymentCode,//code
                        null,//s.PaymentName,//name
                        null,//poid
                        null,//pocode
                        com.CompanyId,//.CusId,
                        com.CompanyName,//s.Company.CompanyName,
                        SummarizePaidMoneyCompany(com),//paid
                        null,//Staff id
                        null,//staff name
                        null,//paiddate
                        null,//paymentmethod id
                        null,//paymentmethod
                        null,//bank id
                        null,//bank name
                        com.Note,//s.Company.Note,
                        null,//com.CreateDate,//s.Company.CreateDate,
                        null,//com.CreateBy,//s.Company.CreateBy,
                        null,//com.ModifyDate,//s.Company.ModifyDate,
                        null,//com.ModifyBy,//s.Company.ModifyBy,
                        SummarizeTotalValue(com)
                    };
            }
            else
            {
                if (level == 1) //Po
                {
                    if (p == null)
                        return null;
                    obj = new object[]
                    {
                        null,//id
                        null,//code
                        null,//name
                        p.PoId,//poid
                        p.PoCode,//pocode
                        null,//s.CusId,
                        null,//s.Company.CompanyName,
                        SummarizePaidMoneyPO(p.PoId),//paid
                        null,//Staff id
                        null,//staff name
                        null,//paiddate
                        null,//paymentmethod id
                        null,//paymentmethod
                        null,//bank id
                        null,//bank name
                        p.Note,
                        null,//p.CreateDate,
                        null,//p.CreateBy,
                        null,//p.ModifyDate,
                        null,//p.ModifyBy,
                        p.TotalValue
                    };
                }
                else //Payment
                {
                    if (s == null)
                        return null;
                    obj = new object[]
                    {
                        s.PaymentId,//id
                        s.PaymentCode,//code
                        s.PaymentName,//name
                        s.POId,//poid
                        null,//pocode
                        s.CusId,//s.CusId,
                        null,//s.Company.CompanyName,
                        s.Paid,//paid
                        s.StaffId,//Staff id
                        s.Staff.StaffName,//staff name
                        UtilityFunction.DateTimeToString((DateTime)s.PaidDate),//s.PaidDate,//paiddate
                        s.PaymentMethodId,//paymentmethod id
                        s.PaymentMethod.Name,//paymentmethod
                        s.BankId,//bank id
                        s.Bank.BankName,//bank name
                        s.Note,
                        s.CreateDate,
                        s.CreateBy,
                        s.ModifyDate,
                        s.ModifyBy,
                        null
                    };
                }
            }
            return obj;
        }

        private void InsertToTreeList(IList<Payment> lst, IList<Company> lstcom, IList<Po> lstpo)
        {
            if (lst == null || lstcom == null | lstpo == null)
                return;
            treeList1.ClearNodes();
            //add level 0
            foreach (var com in lstcom)
            {
                object val0 = CreateObject(0, null, null, com);
                if (val0 == null)
                    return;
                TreeListNode lv0 = treeList1.AppendNode(val0, null);
                lv0.Tag = "Level0";
                //add level 1
                List<Po> po = lstpo.Where(x => x.CompanyId == com.CompanyId).ToList();
                if (po == null)
                    return;
                foreach (var p in po)
                {
                    object val1 = CreateObject(1, null, p, null);
                    if (val1 == null)
                        return;
                    TreeListNode lv1 = treeList1.AppendNode(val1, lv0);
                    lv1.Tag = "Level1";
                    //add level 2
                    List<Payment> pay = lst.Where(x => x.CusId == com.CompanyId && x.POId == p.PoId).ToList();
                    if (pay == null)
                        return;
                    foreach (var pm in pay)
                    {
                        object val3 = CreateObject(2, pm, null, null);
                        if (val3 == null)
                            return;
                        treeList1.AppendNode(val3, lv1);
                    }
                }
            }
            treeList1.ExpandAll();
        }

        private Payment GetSelectedPayment(TreeListNode listNode)
        {
            Payment payment = new Payment();
            payment.PaymentId = Convert.ToInt32(listNode.GetDisplayText("PaymentId"));
            payment.PaymentName = listNode.GetDisplayText("PaymentName");
            payment.POId = new Guid(listNode.GetDisplayText("POId"));
            payment.CusId = Convert.ToInt32(listNode.GetDisplayText("CusId"));
            payment.Paid = Convert.ToInt32(listNode.GetDisplayText("Paid"));
            payment.StaffId = Convert.ToInt32(listNode.GetDisplayText("StaffId"));
            DateTime dt;
            DateTime.TryParse(listNode.GetDisplayText("PaidDate"), System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN"), System.Globalization.DateTimeStyles.None, out dt);
            payment.PaidDate = dt;
            payment.PaymentMethodId = Convert.ToInt32(listNode.GetDisplayText("PaymentMethodId"));
            payment.Note = listNode.GetDisplayText("Note");
            payment.BankId = Convert.ToInt32(listNode.GetDisplayText("BankId"));
            if (listNode.GetDisplayText("CreateDate") != "")
                payment.CreateDate = DateTime.Parse(listNode.GetDisplayText("CreateDate"));
            payment.CreateBy = listNode.GetDisplayText("CreateBy");
            if (listNode.GetDisplayText("ModifyDate") != "")
                payment.ModifyDate = DateTime.Parse(listNode.GetDisplayText("ModifyDate"));
            payment.ModifyBy = listNode.GetDisplayText("ModifyBy");
            return payment;

        }

        private void find(ref TreeListNode node, string poId, List<TreeListNode> listnodes)
        {
            if (listnodes == null)
                return;
            foreach (var v in listnodes)
            {
                if (v.Tag.ToString() == "Level0")
                    find(ref node, poId, v.Nodes.ToList());
                else
                {
                    if (v.Tag.ToString() == "Level1")
                    {
                        if (v.GetDisplayText("POId").ToLower() == poId.ToLower())
                            node = v;
                    }
                }
            }
        }
        #endregion 

        #region Summaries
        private double SummarizePaidMoneyPO(Guid poid)
        {
            double sum = 0F;
            IList<Payment> pm = new List<Payment>();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                pm = uow.PaymentRepository.All(poid);
                uow.Commit();
            }
            //
            foreach (var v in pm)
            {
                if (v.Paid != null)
                {
                    sum += Convert.ToDouble(v.Paid);
                }
            }
            return sum;
        }

        private double SummarizePaidMoneyCompany(Company com)
        {
            double sum = 0F;
            //find payment
            List<Po> pm = new List<Po>();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                pm = uow.PoRepository.Find(com);
                uow.Commit();
            }
            foreach (var v in pm)
            {
                sum += SummarizePaidMoneyPO(v.PoId);
            }
            return sum;
        }

        private double SummarizeTotalValue(Company com)
        {
            double sum = 0F;
            List<Po> pm = new List<Po>();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                pm = uow.PoRepository.Find(com);
                uow.Commit();
            }
            foreach (var v in pm)
            {
                sum += (double)v.TotalValue;
            }
            return sum;
        }
        #endregion

        #region Delegate
        public void InsertOrUpdate(Payment pay, CRUD crud)
        {
            if (crud == CRUD.Insert)
            {
                TreeListNode rooTree = null;
                find(ref rooTree, pay.POId.ToString(), treeList1.Nodes.ToList());
                if (rooTree != null)
                    treeList1.AppendNode(CreateObject(2, pay, null, null), rooTree);
                //update 
                rooTree.SetValue("Paid", SummarizePaidMoneyPO((Guid)pay.POId));
                rooTree.ParentNode.SetValue("Paid", SummarizePaidMoneyCompany(new Company { CompanyId = (int)pay.CusId }));
            }
            else
            {
                TreeListNode node = treeList1.Selection[0];
                node.SetValue("PaymentId", pay.PaymentId);
                node.SetValue("PaymentCode", pay.PaymentCode);
                node.SetValue("PaymentName", pay.PaymentName);
                node.SetValue("POId", pay.POId);
                node.SetValue("CusId", pay.CusId);
                node.SetValue("Paid", pay.Paid);
                node.SetValue("StaffId", pay.StaffId);
                node.SetValue("Staff.StaffName", pay.Staff.StaffName);
                node.SetValue("PaidDate", UtilityFunction.DateTimeToString((DateTime)pay.PaidDate));
                node.SetValue("PaymentMethodId", pay.PaymentMethodId);
                node.SetValue("PaymentMethod.Name", pay.PaymentMethod.Name);
                node.SetValue("BankId", pay.BankId);
                node.SetValue("Bank.BankName", pay.Bank.BankName);
                node.SetValue("Note", pay.Note);
                node.SetValue("CreateDate", pay.CreateDate);
                node.SetValue("CreateBy", pay.CreateBy);
                node.SetValue("ModifyBy", pay.ModifyBy);
                node.SetValue("ModifyDate", pay.ModifyDate);
                //
                node.ParentNode.SetValue("Paid", SummarizePaidMoneyPO((Guid)pay.POId));
                node.ParentNode.ParentNode.SetValue("Paid", SummarizePaidMoneyCompany(new Company { CompanyId = (int)pay.CusId }));
            }
        }
        #endregion

        #region Insert, Update, Delete
        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
            TreeList tree = sender as TreeList;
            TreeListHitInfo hi = tree.CalcHitInfo(tree.PointToClient(Control.MousePosition));
            if (hi.Node != null)
            {
                TreeListNode node = treeList1.Selection[0];
                if (node.Tag == null)
                {
                    Payment pay = new Payment();
                    pay = GetSelectedPayment(node);
                    frmEditPayment editPayment = new frmEditPayment(pay);
                    editPayment.update = InsertOrUpdate;
                    editPayment.ShowDialog();
                }
                else
                    return;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreatePayment obj = new frmCreatePayment();
            obj.insert = InsertOrUpdate;
            obj.ShowDialog();
        }

        private void treeList1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                TreeListNode nodepay = treeList1.Selection[0];
                if (nodepay.Level == 2)
                {
                    DialogResult result = FormUtility.MsgDelete();
                    if (result == DialogResult.Yes)
                    {
                        Payment payment = GetSelectedPayment(nodepay);
                        try
                        {
                            using (IUnitOfWork uow = new UnitOfWork())
                            {
                                uow.PaymentRepository.Remove(payment);
                                uow.Commit();
                            }
                        }
                        catch
                        {
                            labelNotify1.SetText(UI.removefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                            return;
                        }
                        TreeListNode root = nodepay.ParentNode;
                        treeList1.DeleteNode(nodepay);
                        root.SetValue("Paid", SummarizePaidMoneyPO((Guid)payment.POId));
                        labelNotify1.SetText(UI.removesuccess, ToolBoxCS.LabelNotify.EnumStatus.Success);
                    }
                }
                e.Handled = true;
            }
        }

        #endregion

        #region Reload
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadScene();
        }
        #endregion

        #region Search
        private void Search(string txtSearch)
        {
            IList<Payment> lpay = new List<Payment>();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lpay = uow.PaymentRepository.Search(txtSearch);
                uow.Commit();
            }
            //company
            IList<Company> lcom = new List<Company>();
            foreach(var v in lpay.Select(x => x.Company).ToList())
            {
                if (v != null)
                    lcom.Add(v);
            }
            lcom = lcom.DistinctBy(x => x.CompanyName).ToList();
            //po
            IList<Po> lpo = new List<Po>();
            foreach (var v in lpay.Select(x => x.Po).ToList())
            {
                if (v != null)
                    lpo.Add(v);
            }
            lpo = lpo.DistinctBy(x => x.PoCode).ToList();
            //
            treeList1.ClearNodes();
            InsertToTreeList(lpay, lcom, lpo);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtSearch_ButtonClick(null, null);
                e.Handled = true;
            }
        }

        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            Search(txtSearch.Text);
            treeList1.ExpandAll();
        }
        #endregion
    }
}
