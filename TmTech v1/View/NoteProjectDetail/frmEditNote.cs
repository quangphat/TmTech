using System;
using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmEditNote : ModernUI.Forms.MetroForm
    {
        private NoteProjectDetail note;
        public frmEditNote(NoteProjectDetail note)
        {
            InitializeComponent();
            this.note = note;
        }

        private void frmEditNote_Load(object sender, EventArgs e)
        {
            AcceptButton = btnSave;
            labelNotify1.SetText("", ToolBoxCS.LabelNotify.EnumStatus.Other);
            if (note == null)
                return;
            CoverObjectUtility.SetAutoBindingData(this, note);
        }

        public delegate void delgUpdateNote(NoteProjectDetail note, CRUD cru);
        public delgUpdateNote updatenote;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidationUtility.FieldNotAllowNull(this))
                return;
            CoverObjectUtility.GetAutoBindingData(this, note);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.NoteProjectDetailBaseRepository.Update(note);
                    uow.Commit();
                }
                if (updatenote != null)
                    updatenote(note, CRUD.Update);
                Close();
            }
            catch
            {
                labelNotify1.SetText(UI.updatefailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
