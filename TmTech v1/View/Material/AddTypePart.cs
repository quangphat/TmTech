using System;
using System.Windows.Forms;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Utility;

namespace TmTech_v1.View.Material
{
    public partial class AddTypePart : Form
    {
        public AddTypePart()
        {
            InitializeComponent();
            lblNotify1.Text = string.Empty;
        }

        private void groupTypePart_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if( radioButton1.Checked)
            {
                SaveGroupPart();
            }
           else if(radioButton2.Checked )
            {
                SaveTypePart();
            }
            else if(radioButton3.Checked)
            {
                SaveSeriesPart();
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
            Model.GroupPart grouppart = new Model.GroupPart();
            CoverObjectUtility.GetAutoBindingData(groupGroupPart, grouppart);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.GroupPartBaseRepository.Add(grouppart);
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
            Model.TypePart typepart = new Model.TypePart();
            CoverObjectUtility.GetAutoBindingData(groupTypePart, typepart);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.TypePartBaseRepository.Add(typepart);
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
            Model.SeriesPart typepart = new Model.SeriesPart();
            CoverObjectUtility.GetAutoBindingData(groupSeriesPart, typepart);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.SeriesPartBaseRepository.Add(typepart);
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

            if(radioButton1.Checked)
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
    }
}
