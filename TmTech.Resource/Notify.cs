using FlatMessageBox;
using System;
using System.Windows.Forms;

namespace TmTech.Resource
{
    public interface INotify
    {
        DialogResult DeleteItem();
        DialogResult Approve();
        DialogResult CancelApprove();
        DialogResult CloseWithoutSave();
        DialogResult NoInformation();
        DialogResult Warming();
        DialogResult CloseForm();
        DialogResult ItemWasApproved();
    }
    public class FlatNotify : INotify
    {

        public DialogResult DeleteItem()
        {
            return FlatMsgBox.Show(UI.removeitem, UI.warning, FlatMsgBox.Buttons.YesNo);
        }

        public DialogResult Approve()
        {
            return FlatMsgBox.Show(UI.approve, UI.warning, FlatMsgBox.Buttons.YesNo);
        }

        public DialogResult CancelApprove()
        {
            return FlatMsgBox.Show(UI.cancelapprove, UI.warning, FlatMsgBox.Buttons.YesNo);
        }

        public DialogResult CloseWithoutSave()
        {
            return FlatMsgBox.Show(UI.closewithoutsave, UI.warning, FlatMsgBox.Buttons.YesNo);
        }

        public DialogResult NoInformation()
        {
            return FlatMsgBox.Show(UI.removeitem, "không có thông tin chi nhánh", FlatMsgBox.Buttons.YesNo);
        }

        public DialogResult Warming()
        {
            return FlatMsgBox.Show("Hủy bỏ thao tác", UI.warning, FlatMsgBox.Buttons.YesNo);
        }

        public DialogResult CloseForm()
        {
            return FlatMsgBox.Show(UI.datahasbeenchanged, UI.warning, FlatMsgBox.Buttons.YesNo);
        }


        public DialogResult ItemWasApproved()
        {
            return FlatMsgBox.Show(UI.itemwasapproved, "Thông báo", FlatMsgBox.Buttons.OK);
        }
    }
    public class WindowNotify :INotify
    {
        public DialogResult DeleteItem()
        {
            throw new NotImplementedException();
        }

        public DialogResult Approve()
        {
            throw new NotImplementedException();
        }

        public DialogResult CancelApprove()
        {
            throw new NotImplementedException();
        }

        public DialogResult CloseWithoutSave()
        {
            throw new NotImplementedException();
        }

        public DialogResult NoInformation()
        {
            throw new NotImplementedException();
        }

        public DialogResult Warming()
        {
            throw new NotImplementedException();
        }

        public DialogResult CloseForm()
        {
            throw new NotImplementedException();
        }


        public DialogResult ItemWasApproved()
        {
            throw new NotImplementedException();
        }
    }
}
