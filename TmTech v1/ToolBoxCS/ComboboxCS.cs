using System;
using ModernUI.Controls;
namespace TmTech_v1.ToolBoxCS
{
    public  class ComboboxCS : MetroComboBox
  {

      public string NameModel
      {
          get;
          set;
      }
      Boolean isload = true;
      public ComboboxCS comboboxcs { get; set; }

      protected override void OnDropDown(EventArgs e)
      {
           if ( isload ==true)
           {
               LoadData(NameModel);
               isload = false;
           }
          base.OnDropDown(e);
         
      }
    

      private void  LoadData(string model )
      {
          //if( string.IsNullOrEmpty(model))
          //{ this.Items.Add ("--");
          //    return;
          //}
          //else 
          //{
          //    switch (model)
          //    {
          //        case   "CustomerType"  :                      
          //          List<TmTech_v1.Model.CustomerType>  lstTypeCustomer = new List<Model.CustomerType>();
                      
          //             lstTypeCustomer   = Database.GetAll<TmTech_v1.Model.CustomerType>(SqlQuerry.selectCusomerType);
          //             lstTypeCustomer.Add(new TmTech_v1.Model.CustomerType { CustomerTypeId = 0, Name = "(để trống)" });
          //                lstTypeCustomer = lstTypeCustomer.OrderBy(p => p.CustomerTypeId).ToList();
          //                this.DataSource =null;
          //               this.DataSource = lstTypeCustomer;
          //              this.ValueMember = "Id";
          //              this.DisplayMember = "Name";
          //              lstTypeCustomer = null;
          //           break;
          //        case  "Company" :
          //           List<TmTech_v1.Model.Company> lstCompany = new List<Model.Company>();

          //           lstCompany = Database.GetAll<TmTech_v1.Model.Company>(SqlQuerry.selectCompany);
          //           lstCompany.Add(new TmTech_v1.Model.Company { CompanyId = 0,CompanyName= "(để trống)" });
          //           lstCompany = lstCompany.OrderBy(p => p.CompanyId).ToList();
          //                this.DataSource =null;
          //                this.DataSource = lstCompany;
          //              this.ValueMember = "Id";
          //              this.DisplayMember = "Name";
          //              lstTypeCustomer = null;
          //           break; 

          //        default  :
          //         this.Items.Add("--");                       
          //          break;   
          //    }
          //}
      }

      private void InitializeComponent()
      {
            SuspendLayout();
            ResumeLayout(false);

      }
    }
}
