using System;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View.Material
{
    public partial class EditTyePart : Form
    {

        RequestParamaterEditTypeForm _request;

        public EditTyePart(RequestParamaterEditTypeForm requestform)
        {
            InitializeComponent();
            lblNotify1.Text = string.Empty;
            _request = requestform;
        }

        private void groupTypePart_Enter(object sender, EventArgs e)
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_request.editTypeRequestFrm == EditTypeRequest.GroupPart)
            {
                radioButton1.Checked = true;
                SaveGroupPart();

            }

            else if (_request.editTypeRequestFrm == EditTypeRequest.SeriesPart)
            {
                radioButton3.Checked = true;
                SaveSeriesPart();

            }

            else if (_request.editTypeRequestFrm == EditTypeRequest.TypePart)
            {
                radioButton2.Checked = true;
                SaveTypePart();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void SaveGroupPart()
        {
            if (!radioButton1.Checked)
                return;
            if (ValidationUtility.FieldNotAllowNull(groupGroupPart) == false) return;
            Model.GroupPart grouppart = _request.groupPart;
            CoverObjectUtility.GetAutoBindingData(groupGroupPart,grouppart );
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.GroupPartBaseRepository.Update(grouppart);
                    uow.Commit();
                }

                Close();

            }
            catch
            {
                lblNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        void SaveTypePart()
        {
            if (!radioButton2.Checked)
                return;
            if (ValidationUtility.FieldNotAllowNull(groupGroupPart) == false) return;
            Model.TypePart typepart = _request.typePart;
            CoverObjectUtility.GetAutoBindingData(groupTypePart, typepart);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.TypePartBaseRepository.Update(typepart);
                    uow.Commit();
                }

                Close();
            }
            catch
            {
                lblNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        void SaveSeriesPart()
        {
            if (!radioButton2.Checked)
                return;
            if (ValidationUtility.FieldNotAllowNull(groupGroupPart) == false) return;
            Model.SeriesPart typepart = _request.seriesPart;
            CoverObjectUtility.GetAutoBindingData(groupSeriesPart,typepart );
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.SeriesPartBaseRepository.Update(typepart);
                    uow.Commit();
                }

                Close();
            }
            catch
            {
                lblNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void grouppartshow(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                groupTypePart.Hide();
                groupSeriesPart.Hide();
                groupGroupPart.Show();
            }

        }

        private void typepartshow(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupTypePart.Show();
                groupSeriesPart.Hide();
                groupGroupPart.Hide();
            }


        }

        private void seriespartshow(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                groupTypePart.Hide();
                groupSeriesPart.Show();
                groupGroupPart.Hide();
            }

        }

        private void EditTyePart_Load(object sender, EventArgs e)
        {
            if (_request.editTypeRequestFrm == EditTypeRequest.GroupPart)
            {
                radioButton1.Checked = true;
                CoverObjectUtility.SetAutoBindingData(groupGroupPart, _request.groupPart);

            }

            else if (_request.editTypeRequestFrm == EditTypeRequest.SeriesPart)
            {
                radioButton3.Checked = true;
                CoverObjectUtility.SetAutoBindingData(groupGroupPart, _request.seriesPart);

            }

            else if (_request.editTypeRequestFrm == EditTypeRequest.TypePart)
            {
                radioButton2.Checked = true;
                CoverObjectUtility.SetAutoBindingData(groupGroupPart, _request.typePart);
            }
        }
    }
}

