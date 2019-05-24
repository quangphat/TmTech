namespace TmTech_v1.ToolBoxCS
{
    public  class TextBoxPassword : TextBoxValidation
    {



      protected override void OnCreateControl()
      {
          PasswordChar = '*';
          base.OnCreateControl();
      }
  }
}
