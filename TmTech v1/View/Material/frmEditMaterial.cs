using ModernUI.Forms;
using System;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;
using System.Text;

namespace TmTech_v1.View
{
    public partial class frmEditMaterial : MetroForm
    {
        Model.Material m_Material;
        private Boolean isLoad = true;
        MaterialRequestDataBase materialRequestDataBase;
       
        public frmEditMaterial(MaterialRequestDataBase materialrequest)
        {
            InitializeComponent();
            materialRequestDataBase = materialrequest;
            m_Material = materialrequest.Model;
            lblNotify1.Text = "";

        }
       
        public frmEditMaterial(Model.Material material)
        {
            InitializeComponent();
            m_Material = material;
            lblNotify1.Text = "";
            FormUtility.FormatForm(this);
        }


        private void frmEditMaterial_Load(object sender, EventArgs e)
        {
            ComboboxUtility.BindSupplier(cbbSupplier);
            ComboboxUtility.BindGroupPart(cbbGroupPart);
            ComboboxUtility.BindTypePartWidthALl(cbbTypePart,"0");
            ComboboxUtility.BindSeriesParttWidthALl(cbbSeriesPart,"0");
            ComboboxUtility.BindUnit(cbbUnit);
            FormUtility.FormatForm(this);
            FormUtility.ResetForm(this);
          
            if (!materialRequestDataBase.IsEdit)
            {
               
                this.Text = UI.MateralCreateTilteForm;
            }
            else
            {
                this.Text = UI.MateralEditTilteForm;
            }

            InititalizeForm(m_Material);


        }
        private void InititalizeForm(Model.Material material)
        {
            CoverObjectUtility.SetAutoBindingData(this, material);
            isLoad = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public delegate void delgUpdateRow(Model.Material material,CRUD flag);
        public delgUpdateRow UpdateRow;
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidationUtility.FieldNotAllowNull(this) == false)
                return;
            CoverObjectUtility.GetAutoBindingData(this, m_Material);
            m_Material.Supplier = cbbSupplier.SelectedItem != null ? cbbSupplier.SelectedItem as Model.Supplier : new Model.Supplier();
            m_Material.GropsupplierMaterial = cbbGroupPart.SelectedItem != null ? cbbGroupPart.SelectedItem as GroupPart : new GroupPart();
            m_Material.TypePartMaterial = cbbTypePart.SelectedItem != null ? cbbTypePart.SelectedItem as TypePart : new TypePart();
            m_Material.SeriesPartMaterial = cbbSeriesPart.SelectedItem != null ? cbbSeriesPart.SelectedItem as SeriesPart : new SeriesPart();
            m_Material.UnitMaterial = cbbUnit.SelectedItem != null ? cbbUnit.SelectedItem as Unit : new Unit();
            m_Material.SupplierId = m_Material.Supplier.SupplierId;
            m_Material.GroupPartId = m_Material.GropsupplierMaterial.GroupPartId;
            m_Material.TypePartId = m_Material.TypePartMaterial.TypePartID;
            m_Material.SeriesPartId = m_Material.SeriesPartMaterial.SeriesPartId;
            m_Material.UnitId = m_Material.UnitMaterial.UnitId;

            m_Material.MaterialCode = GenericCodeMaterial(m_Material);
            if (materialRequestDataBase.IsEdit)
            {
                try
                {
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.MaterialRepository.Update(m_Material);
                        uow.Commit();
                    }
                    if(materialRequestDataBase.gridview!=null)
                        materialRequestDataBase.gridview.RefreshData();
                    this.Close();

                }
                catch (Exception ex)
                {
                    lblNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                }
              

            }
            else
            {
                try
                {
                    using (IUnitOfWork uow = new UnitOfWork())
                    {
                        uow.MaterialRepository.Add(m_Material);
                        uow.Commit();
                    }
                    materialRequestDataBase.AddOrUpdateRow(m_Material, CRUD.Insert);
                 
                    this.Close();
                }
                catch (Exception ex)
                {
                    lblNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
                }
            }
         
        }

        private void lnkChangeHinhanh_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUtility.OpenImage(ptPicture);
        }
        private void linkCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private  string GenericCodeMaterial (Model.Material materiaGen)
        {
           
            var code = new StringBuilder();
            code.Append(materiaGen.LoactionCode);
            code.Append("_");
            code.Append(materiaGen.ProductTypeCode);
            code.Append("_");
            code.Append(materiaGen.DepartmentCode);
            code.Append("_");
            code.Append(GenericNameCode(materiaGen.MaterialName));
            code.Append("_");
            code.Append(materiaGen.StandardCode);
            code.Append("_");
            code.Append(new Guid().ToString());
            return code.ToString();
        }


         string GenericNameCode(string inputString)
        {

            if (string.IsNullOrEmpty(inputString) || string.IsNullOrWhiteSpace(inputString))
                return string.Empty;
            var subStringName = inputString.Split(' ');
            var resulfName = new StringBuilder();

            foreach (var item in subStringName)
            {
                try
                {
                    resulfName.Append(item.Substring(0, 1).ToUpper());
                }
                catch (Exception)
                {

                }

            }

            return resulfName.ToString();
        }

        private void cbbGroupPart_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isLoad)
                return;
            GroupPart group = cbbGroupPart.SelectedItem as GroupPart;
            if (group == null) return;
            int grouppartId = group.GroupPartId;
            ComboboxUtility.BindTypePartWidthALl(cbbTypePart, grouppartId.ToString());
        }

        private void cbbTypePart_SelectedValueChanged(object sender, EventArgs e)
        {
            if (isLoad)
                return;
            TypePart type = cbbTypePart.SelectedItem as TypePart;
            if (type == null)
                return;
            int typepartId = type.TypePartID;
            ComboboxUtility.BindSeriesParttWidthALl(cbbSeriesPart, typepartId.ToString());
        }

        private void autoSearchCombobox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
