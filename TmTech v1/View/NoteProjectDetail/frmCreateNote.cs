using TmTech.Resource;
using TmTech_v1.Interface;
using TmTech_v1.Model;
using TmTech_v1.Utility;

namespace TmTech_v1.View
{
    public partial class frmCreateNote : ModernUI.Forms.MetroForm
    {
        public frmCreateNote()
        {
            InitializeComponent();
        }

        public delegate void delgInsertNote(NoteProjectDetail note, CRUD cru);
        public delgInsertNote insertnote;
        
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            if (!ValidationUtility.FieldNotAllowNull(this))
                return;
            NoteProjectDetail note = new NoteProjectDetail();
            CoverObjectUtility.GetAutoBindingData(this, note);
            try
            {
                using (IUnitOfWork uow = new UnitOfWork())
                {
                    uow.NoteProjectDetailBaseRepository.Add(note);
                    uow.Commit();
                }
                if (insertnote != null)
                    insertnote(note, CRUD.Insert);
                Close();
            } catch
            {
                labelNotify1.SetText(UI.createfailed, ToolBoxCS.LabelNotify.EnumStatus.Failed);
            }
        }

        private void frmCreateNote_Load(object sender, System.EventArgs e)
        {
            labelNotify1.SetText("", ToolBoxCS.LabelNotify.EnumStatus.Other);
            AcceptButton = btnCreate;
        }
    }
}
