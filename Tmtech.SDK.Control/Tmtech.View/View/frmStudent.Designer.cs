namespace Tmtech.View.View
{
    partial class frmStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.autoTextBox2 = new Tmtech.SDK.Control.AutoTextBox();
            this.autoTextBox1 = new Tmtech.SDK.Control.AutoTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // autoTextBox2
            // 
            this.autoTextBox2.BackColor = System.Drawing.Color.LightYellow;
            this.autoTextBox2.BindingFor = null;
            this.autoTextBox2.BindingName = null;
            this.autoTextBox2.ForeColor = System.Drawing.Color.Black;
            this.autoTextBox2.IsPassword = false;
            this.autoTextBox2.IsRequire = false;
            this.autoTextBox2.Location = new System.Drawing.Point(109, 72);
            this.autoTextBox2.Name = "autoTextBox2";
            this.autoTextBox2.Size = new System.Drawing.Size(100, 20);
            this.autoTextBox2.TabIndex = 0;
            // 
            // autoTextBox1
            // 
            this.autoTextBox1.BackColor = System.Drawing.Color.LightYellow;
            this.autoTextBox1.BindingFor = null;
            this.autoTextBox1.BindingName = null;
            this.autoTextBox1.ForeColor = System.Drawing.Color.Black;
            this.autoTextBox1.IsPassword = false;
            this.autoTextBox1.IsRequire = false;
            this.autoTextBox1.Location = new System.Drawing.Point(109, 22);
            this.autoTextBox1.Name = "autoTextBox1";
            this.autoTextBox1.Size = new System.Drawing.Size(100, 20);
            this.autoTextBox1.TabIndex = 0;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 172);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autoTextBox2);
            this.Controls.Add(this.autoTextBox1);
            this.Name = "frmStudent";
            this.Text = "frmStudent";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SDK.Control.AutoTextBox autoTextBox1;
        private SDK.Control.AutoTextBox autoTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}