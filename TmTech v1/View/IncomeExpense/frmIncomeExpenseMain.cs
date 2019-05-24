using DevExpress.XtraGrid.Views.Grid;
using FlatMessageBox;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmIncomeExpenseMain : UserControl
    {
        IList<IncomeExpense> lstincome;
        GridUtility gridUtility;
        string detail;
        
        public frmIncomeExpenseMain()
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1);
        }

        private void frmIncomeExpenseMain_Load(object sender, System.EventArgs e)
        {
            labelNotify1.Text = "";
            loadDB(DateTime.Now);
            label3.Text = UtilityFunction.DateTimeToString(DateTime.Now);
        }

        private void loadDB(DateTime dt)
        {
            lstincome = new List<IncomeExpense>();
            using (IUnitOfWork uow = new UnitOfWork())
            {
                lstincome = uow.IncomeExpenseRepository.Find(dt);
                uow.Commit();
            }
            if (lstincome == null)
                return;
            gridUtility.BindingData(lstincome);

        }

        #region Button Request
        private void GetDetail(string value)
        {
            detail = value;
        }
        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            IncomeExpense ie = new IncomeExpense();
            ie = gridUtility.GetSelectedItem<IncomeExpense>();
            ie.IncomeExpenseId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["IncomeExpenseId"]));
            if (ie.ApproveStatusId == 1)
            {
                FlatMsgBox.Show("Đã có một yêu cầu khác gửi đi ở dòng này đang chờ xác nhận, không thể gửi thêm yêu cầu.");
                return;
            }
            if (ie == null)
                return;
            RequestSent rs = new RequestSent();
            rs.TableName = "IncomeExpense";
            rs.IdValue = ie.IncomeExpenseId;
            rs.RequestTo = "quangphat";
            rs.RequestBy = UserManagement.UserSession.UserName;
            frmEditIncomExpense obj = new frmEditIncomExpense();
            obj.value = GetDetail;
            obj.ShowDialog();
            if (detail == null)
                return;
            rs.Detail = detail;

            try
            {
                ie.ApproveStatusId = 1;
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.RequestSentRepository.Add(rs);
                    uow.IncomeExpenseRepository.Update(ie);
                    uow.Commit();
                }
                FlatMsgBox.Show("Yêu cầu đã được gửi");
                detail = null;
            }
            catch
            {
                FlatMsgBox.Show("Không thể gửi yêu cầu");
            }
        }
        #endregion

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            gridUtility.DrawStatusColor(sender, e, colStatus, colSophieu);
            gridUtility.DrawColorForIncomeExpense(sender, e, colPurpose, colContent);
        }

        #region Create new
        private void Add(IncomeExpense sug)
        {
            gridUtility.AddNewRow(sug);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmSuggest obj = new frmSuggest();
            obj.add = Add;
            obj.ShowDialog();
        }
        #endregion

    }
}