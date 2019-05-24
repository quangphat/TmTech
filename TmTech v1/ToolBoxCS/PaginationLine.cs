using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TmTech_v1.ToolBoxCS
{
    public partial class PaginationLine : UserControl
    {
        private const int initialCenterPage = 3;//center page in initialize.
        private float fontSize = 14.25F;
        [Category("Font")]
        public float FontSize
        {
            get { return fontSize; }
            set { fontSize = value; }
        }
        private string fontName = "Segoe UI Symbol";
        [Category("Font")]
        public string FontName
        {
            get { return fontName; }
            set { fontName = value; }
        }
        private int totalPage = 5;
        public int TotalPage
        {
            get { return totalPage; }
            set
            {
                totalPage = value;
                generateListPage();
            }
        }
        private Color textColor = ColorTranslator.FromHtml("#0088cc");
        public Color TextColor
        {
            get { return textColor; }
            set { textColor = value; }
        }
        private Color selectedTextColor = Color.White;
        public Color SelectedForeColor
        {
            get { return selectedTextColor; }
            set { selectedTextColor = value; }
        }
        private Font font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular);

        private enum pages { first = -1, previous = 0, lbl1 = 1, lbl2 = 2, lbl3 = 3, lbl4 = 4, lbl5 = 5, next = 6, final = 7 };
        private int selectedPage = 1;
        public int SelectedPage
        {
            get { return selectedPage; }
        }
        private int pCenter = 3;
        private int lastPage = 5;
        private int distance = 0;
        private Color selectPageColor = ColorTranslator.FromHtml("#337ab7");
        public Color SelectedPageColor
        {
            get { return selectPageColor; }
            set { selectPageColor = value; }
        }
        private List<Label> m_lstLabel = new List<Label>();
        public PaginationLine()
        {
            InitializeComponent();
            font = new Font(this.fontName, this.fontSize, FontStyle.Regular);
            generatePageInline();
            lblFinal.Click += lblFinal_Click;
            lblNext.Click += lblNext_Click;
            lbl5.Click += lbl5_Click;
            lbl4.Click += lbl4_Click;
            lbl3.Click += lbl3_Click;
            lbl2.Click += lbl2_Click;
            lbl1.Click += lbl1_Click;
            lblPrev.Click += lblPrev_Click;
            lblFirst.Click += lblFirst_Click;
        }

        void lblFirst_Click(object sender, EventArgs e)
        {
            selectedPage = 1;
            SelectPageChange(e);
        }

        void lblPrev_Click(object sender, EventArgs e)
        {
            selectedPage -= 1;
            if (selectedPage >= 1)
                SelectPageChange(e);
            else
                selectedPage += 1;
        }

        void lbl1_Click(object sender, EventArgs e)
        {
            selectedPage = int.Parse(lbl1.Text);
            SelectPageChange(e);
        }

        void lbl2_Click(object sender, EventArgs e)
        {
            selectedPage = int.Parse(lbl2.Text);
            SelectPageChange(e);
        }

        void lbl3_Click(object sender, EventArgs e)
        {
            selectedPage = int.Parse(lbl3.Text);
            SelectPageChange(e);
        }

        void lbl4_Click(object sender, EventArgs e)
        {
            selectedPage = int.Parse(lbl4.Text);
            SelectPageChange(e);
        }

        void lbl5_Click(object sender, EventArgs e)
        {
            selectedPage = int.Parse(lbl5.Text);
            SelectPageChange(e);
        }

        void lblNext_Click(object sender, EventArgs e)
        {
            selectedPage += 1;
            if (selectedPage <= totalPage)
                SelectPageChange(e);
            else
                selectedPage -= 1;
        }

        void lblFinal_Click(object sender, EventArgs e)
        {
            List<Label> lstLabel = GetLabels();
            selectedPage = totalPage;
            SelectPageChange(e);
        }
        private void generatePageInline()
        {
            m_lstLabel = GetLabels();

            if (m_lstLabel != null)
            {
                foreach (Label lbl in m_lstLabel)
                {
                    lbl.Font = new Font(this.fontName, this.fontSize, FontStyle.Regular);
                    if (lbl.Name != "lblFirst" && lbl.Name != "lblPrev" && lbl.Name != "lblNext" && lbl.Name != "lblFinal" && lbl.Name != "lblPagePerTotal")
                    {
                        lbl.ForeColor = this.textColor;
                    }
                }
            };
        }
        private void generatePagenumber()
        {
            if (selectedPage < initialCenterPage)
            {
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
            }
            else
            {
                if (selectedPage < pCenter)
                {
                    distance = selectedPage - pCenter;
                    lbl1.Text = (selectedPage - 2).ToString();
                    lbl2.Text = (selectedPage - 1).ToString();
                    lbl3.Text = (selectedPage).ToString();
                    lbl4.Text = (selectedPage + 1).ToString();
                    lbl5.Text = (selectedPage + 2).ToString();
                }
            }
            if (selectedPage > pCenter && selectedPage <= totalPage && totalPage - selectedPage <= 1)
            {
                lbl1.Text = (totalPage - 4).ToString();
                lbl2.Text = (totalPage - 3).ToString();
                lbl3.Text = (totalPage - 2).ToString();
                lbl4.Text = (totalPage - 1).ToString();
                lbl5.Text = (totalPage - 0).ToString();
            }
            else
                if (selectedPage >= pCenter)
                {
                    lbl1.Text = (selectedPage - 2).ToString();
                    lbl2.Text = (selectedPage - 1).ToString();
                    lbl3.Text = (selectedPage - 0).ToString();
                    lbl4.Text = (selectedPage + 1).ToString();
                    lbl5.Text = (selectedPage + 2).ToString();
                }
            m_lstLabel.Where(p => p.Name == "lbl1").Single().Text = lbl1.Text;
            m_lstLabel.Where(p => p.Name == "lbl2").Single().Text = lbl2.Text;
            m_lstLabel.Where(p => p.Name == "lbl3").Single().Text = lbl3.Text;
            m_lstLabel.Where(p => p.Name == "lbl4").Single().Text = lbl4.Text;
            m_lstLabel.Where(p => p.Name == "lbl5").Single().Text = lbl5.Text;
        }
        private List<Label> GetLabels()
        {
            return this.Controls.OfType<Label>().Cast<Label>().ToList();
        }
        private void SelectPageChange(EventArgs e)
        {
            generatePagenumber();
            setPageVisible();
            lastPage = int.Parse(lbl5.Text);
            float lbl3Value = float.Parse(lbl3.Text);
            pCenter = int.Parse(lbl3.Text);
            lblPagePerTotal.Text = selectedPage.ToString() + "/" + totalPage.ToString();
            if (PageClick != null)
            {
                PageClick(selectedPage, e);
            }
        }
        private void setPageVisible()
        {
            foreach (Label lbl in m_lstLabel)
            {
                if (lbl.Name != "lblFirst" && lbl.Name != "lblPrev" && lbl.Name != "lblNext" && lbl.Name != "lblFinal" && lbl.Name != "lblPagePerTotal")
                {
                    if (int.Parse(lbl.Text) > totalPage)
                        lbl.Visible = false;
                    else
                    {
                        if (selectedPage == int.Parse(lbl.Text))
                        {
                            lbl.BackColor = this.selectPageColor;
                            lbl.ForeColor = this.selectedTextColor;
                        }
                        else
                        {
                            lbl.BackColor = Color.White;
                            lbl.ForeColor = textColor;
                        }
                    }

                }
            }
        }
        private void generateListPage()
        {
            int ceil = totalPage / 10;
            cbbListPage.DataSource = null;
            cbbListPage.Items.Clear();
            cbbListPage.Items.Add(1);
            for (int i = 1; i < ceil + 1; i++)
            {
                cbbListPage.Items.Add(i * 10);
            }
        }
        public event EventHandler PageClick;
    }
}
