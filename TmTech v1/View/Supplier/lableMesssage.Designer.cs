﻿namespace TmTech_v1.View.Supplier
{
    partial class lableMesssage
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
            this.lblInformationMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInformationMessage
            // 
            this.lblInformationMessage.AutoSize = true;
            this.lblInformationMessage.Location = new System.Drawing.Point(96, 40);
            this.lblInformationMessage.Name = "lblInformationMessage";
            this.lblInformationMessage.Size = new System.Drawing.Size(0, 13);
            this.lblInformationMessage.TabIndex = 0;
            // 
            // lableMesssage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 91);
            this.Controls.Add(this.lblInformationMessage);
            this.Name = "lableMesssage";
            this.Load += new System.EventHandler(this.lableMesssage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformationMessage;
    }
}