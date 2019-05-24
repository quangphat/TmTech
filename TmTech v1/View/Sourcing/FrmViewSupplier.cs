using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View.Sourcing
{


    public partial class FrmViewSupplier : UserControl
    {
        GridUtility gridUtility;
        public FrmViewSupplier() 
        {
            InitializeComponent();
            gridUtility = new GridUtility(gridControl1);
            ComboboxUtility.BindSupplierWidthALl(cbSupplier);
            cbSupplier.SelectedValue = 100;
            ComboboxUtility.BindGroupPartWidthALl(cbGroupPart);
            cbGroupPart.SelectedValue = 0;
            ComboboxUtility.BindTypePartWidthALl(cbTypePart, cbGroupPart.SelectedValue.ToString());
            cbTypePart.SelectedValue = 0;
            ComboboxUtility.BindSeriesParttWidthALl(cbSeriesPart, cbTypePart.SelectedValue.ToString());
            cbSeriesPart.SelectedValue = 0;
            ComboboxUtility.BindParttWidthALl(cbPart,cbSeriesPart.SelectedValue.ToString());
            cbPart.SelectedValue = 0;
            Dock = DockStyle.Fill;
            //FormUtility.LoadEventCommonControl(this);


            
        }
        private static FrmViewSupplier _instance;
        public static FrmViewSupplier Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new FrmViewSupplier();
            }

            return _instance;
        }
        public void  LoadInformationSearch( InformationSearch _searchInfor)
        {
            cbSupplier.SelectedValue = _searchInfor.SupplierID > -1 ? _searchInfor.SupplierID : 100;
            cbGroupPart.SelectedValue = _searchInfor.SupplierID > 0 ? _searchInfor.GroupPartID : 0;
            cbTypePart.SelectedValue = _searchInfor.SupplierID > 0 ? _searchInfor.TypePartID : 0;
            cbSeriesPart.SelectedValue = _searchInfor.SupplierID > 0 ? _searchInfor.SeriesPartID : 0;
            cbPart.SelectedValue = _searchInfor.SupplierID > 0 ? _searchInfor.PartID : 0;
            Search();

        }
    
        public FrmViewSupplier(InformationSearch _searchInfor)
        {
            InitializeComponent();
            ComboboxUtility.BindSupplierWidthALl(cbSupplier);
            cbSupplier.SelectedValue = 100;
            ComboboxUtility.BindGroupPartWidthALl(cbGroupPart);
            cbGroupPart.SelectedValue = 0;
            ComboboxUtility.BindTypePartWidthALl(cbTypePart, cbGroupPart.SelectedValue.ToString());
            cbTypePart.SelectedValue = 0;
            ComboboxUtility.BindSeriesParttWidthALl(cbSeriesPart, cbTypePart.SelectedValue.ToString());
            cbSeriesPart.SelectedValue = 0;
            ComboboxUtility.BindParttWidthALl(cbPart, cbSeriesPart.SelectedValue.ToString());
            cbPart.SelectedValue = 0;
            Dock = DockStyle.Fill;
            //FormUtility.LoadEventCommonControl(this);

            cbSupplier.SelectedValue = _searchInfor.SupplierID>-1 ? _searchInfor.SupplierID:100;
            cbGroupPart.SelectedValue = _searchInfor.SupplierID > 0 ? _searchInfor.GroupPartID : 0;
            cbTypePart.SelectedValue = _searchInfor.SupplierID > 0 ? _searchInfor.TypePartID : 0;
            cbSeriesPart.SelectedValue = _searchInfor.SupplierID > 0 ? _searchInfor.SeriesPartID : 0;
            cbPart.SelectedValue = _searchInfor.SupplierID > 0 ? _searchInfor.PartID : 0;
            Search();
        }
        private void Search()
        {
            string querySql = @"select pa.PartNumber,   sp.SupplierName,sp.SupplierId,sub.SubSupplierName,sp.Address as 'AddressSupplier', sub.Phone,sub.Fax,sub.Skype,gp.GroupPartName,gp.GroupPartId,
tp.TypePartName,tp.TypePartID,se.SeriesPartId,se.SeriesPartName,pa.partName,pa.PartID,
sp.Email,sp.isActive as 'StatusSupplier',  pa.Description as 'NOte', pa.Pricespart , pa.CreateDate, pa.CreateBy,pa.ModifyDate, pa.ModifyBy
 from  GroupPart gp inner join TypePart tp on gp.GroupPartId = tp.GroupPartId 
inner join SeriesPart se on  tp.TypePartID =se.TypePartId  
inner join Part pa on se.SeriesPartId = pa.SeriesPartID 

inner join Sourcing sc on pa.PartID =sc.PartID
inner join Supplier sp on sp.SupplierId = sc.SupplierID
inner join SubSupplier sub  on sp.SupplierId = sub.SupplierId where sub.IsActive =1";

            if (string.IsNullOrWhiteSpace(txtToken.Text) == false && string.IsNullOrEmpty(txtToken.Text) == false)
            {
                string textQuerry = txtToken.Text;
                querySql += @" and sp.SupplierName like '%" + textQuerry + @"%' or sp.Address like '%" + textQuerry + @"%'
or sub.Phone like '%" + textQuerry + @"%'  or sub.Fax like '%" + textQuerry + @"%'  or sub.Skype like '%" + textQuerry + @"%'
or sp.Email like '%" + textQuerry + @"%'";

                if (cbSupplier.SelectedValue.ToString() != "100")
                {
                    querySql += " and sp.SupplierId =" + cbSupplier.SelectedValue.ToString();
                }

                if (cbGroupPart.SelectedValue.ToString() != "0")
                {
                    querySql += " and gp.GroupPartId =" + cbGroupPart.SelectedValue.ToString();
                }


                if (cbTypePart.SelectedValue.ToString() != "0")
                {
                    querySql += " and tp.TypePartID =" + cbTypePart.SelectedValue.ToString();
                }

                if (cbSeriesPart.SelectedValue.ToString() != "0")
                {
                    querySql += " and se.SeriesPartId =" + cbSeriesPart.SelectedValue.ToString();
                }


                if (cbPart.SelectedValue.ToString() != "0")
                {
                    querySql += " and pa.PartID =" + cbPart.SelectedValue.ToString();
                }
            }
            else
            {
                if (cbSupplier.SelectedValue.ToString() != "100")
                {
                    querySql += " and sp.SupplierId =" + cbSupplier.SelectedValue.ToString();
                }

                if (cbGroupPart.SelectedValue.ToString() != "0")
                {
                    querySql += " and gp.GroupPartId =" + cbGroupPart.SelectedValue.ToString();
                }


                if (cbTypePart.SelectedValue.ToString() != "0")
                {
                    querySql += " and tp.TypePartID =" + cbTypePart.SelectedValue.ToString();
                }

                if (cbSeriesPart.SelectedValue.ToString() != "0")
                {
                    querySql += " and se.SeriesPartId =" + cbSeriesPart.SelectedValue.ToString();
                }


                if (cbPart.SelectedValue.ToString() != "0")
                {
                    querySql += " and pa.PartID =" + cbPart.SelectedValue.ToString();
                }



            }
            if (querySql.EndsWith(" and  "))
            {
                querySql = @"select pa.PartNumber,   sp.SupplierName,sp.SupplierId,sub.SubSupplierName,sp.Address as 'AddressSupplier', sub.Phone,sub.Fax,sub.Skype,gp.GroupPartName,gp.GroupPartId,
tp.TypePartName,tp.TypePartID,se.SeriesPartId,se.SeriesPartName,pa.partName,pa.PartID,
sp.Email,sp.isActive as 'StatusSupplier',  pa.Description as 'NOte', pa.Pricespart , pa.CreateDate, pa.CreateBy,pa.ModifyDate, pa.ModifyBy
 from  GroupPart gp inner join TypePart tp on gp.GroupPartId = tp.GroupPartId 
inner join SeriesPart se on  tp.TypePartID =se.TypePartId  
inner join Part pa on se.SeriesPartId = pa.SeriesPartID 

inner join Sourcing sc on pa.PartID =sc.PartID
inner join Supplier sp on sp.SupplierId = sc.SupplierID
inner join SubSupplier sub  on sp.SupplierId = sub.SupplierId where sub.IsActive =1";
            }

            List<ViewSupplierSourcing> lstviewsupplier = new List<ViewSupplierSourcing>();

            using (UnitOfWork uow = new UnitOfWork())
            {
                lstviewsupplier = uow.PartBaseRepository.PartOfSupplier(querySql);
                uow.Commit();

            }

            gridUtility.BindingData<ViewSupplierSourcing>(lstviewsupplier);
            gridView1.RefreshData();




        }

        private void btnLookForProduct_Click(object sender, EventArgs e)
        {

            Search();
           

        }
    }
}
