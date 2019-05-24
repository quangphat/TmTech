using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tmtech.SDK.Control.Model;

namespace TestControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadTest()
        {

            var listTest = new List<Test>()
            {
                new Test ()
                {
                     Id = Guid.NewGuid().ToString(),
                    Name =false,
                    Datetime =DateTime.UtcNow
                },
                new Test ()
                {
                      Id = Guid.NewGuid().ToString(),
                      Name =false,
                      Datetime =DateTime.UtcNow
                },
                new Test ()
                {
                      Id = Guid.NewGuid().ToString(),
                      Name =false,
                      Datetime =DateTime.UtcNow
                },
                new Test ()
                {
                      Id = Guid.NewGuid().ToString(),
                      Name =false,
                      Datetime =DateTime.UtcNow
                }
            };
            var list = new List<ColumnGrid>()
            {
                new ColumnGrid()
                {
                    Caption = TestOrderBy.Id.ToString(),
                    FieldName =  TestOrderBy.Id.ToString(),
                    Name =  "Column1",
                    Width =100
                },
                new ColumnGrid()
                {
                    Caption =  TestOrderBy.Name.ToString(),
                    FieldName =  TestOrderBy.Name.ToString(),
                    Name =  "Column2",
                    Width =200
                },
                 new ColumnGrid()
                {
                    Caption =  TestOrderBy.Datetime.ToString(),
                    FieldName =  TestOrderBy.Datetime.ToString(),
                    Name = TestOrderBy.Datetime.ToString(),
                    Width =200
                }
            };
            gridControlView1.AddColumn(list);


            
            gridControlView1.PrimaryKey = TestOrderBy.Id.ToString();
            gridControlView1.DataSource = listTest;
            gridControlView1.DataSource = listTest;

            this.gridControlView1.DoubleClickRow = DoubleRow;
            this.gridControlView1.RowClick = RowClick;
            this.gridControlView1.GridViewData.OptionsBehavior.Editable = false;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = gridControlView1.SelectRow<Test>();

            var item1 = new Test()
            {
                Id =  Guid.NewGuid().ToString(),
                Name = true,
                Datetime = new DateTime(1993, 05, 13)
            };
            this.gridControlView1.Delete(item);
           
          
        }


        void DoubleRow(object sender)
        {

        }

        void RowClick(object sender)
        {

        }
     
    }
}
