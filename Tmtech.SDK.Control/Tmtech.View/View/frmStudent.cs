using Autofac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tmtech.Business.IBussiness;
using Tmtech.SDK.Core.Model;
using Tmtech.View.Model;

namespace Tmtech.View.View
{
    public partial class frmStudent : Form
    {
        private readonly IStudentBussiness studentBussiness;
        private StudentView studentview;
        public frmStudent()
        {
            InitializeComponent();
            using (var scope = Bootstap.Regiter.BeginLifetimeScope())
            {
                studentBussiness = scope.ResolveOptional<IStudentBussiness>();
            }
            studentview = new StudentView(new Student());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentview.item.Name = autoTextBox1.Text;
            studentBussiness.Insert(studentview.item);
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            autoTextBox1.Text = studentview.item.Name;
        }
    }
}
