namespace Bank.Clients
{
    partial class FrmFindClient
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.CBFindBy = new System.Windows.Forms.ComboBox();
            this.TBFindBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFindBy = new System.Windows.Forms.Button();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.ctrlFindClient1 = new Bank.Clients.CtrlFindClient();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(632, 554);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // CBFindBy
            // 
            this.CBFindBy.FormattingEnabled = true;
            this.CBFindBy.Location = new System.Drawing.Point(113, 35);
            this.CBFindBy.Name = "CBFindBy";
            this.CBFindBy.Size = new System.Drawing.Size(121, 21);
            this.CBFindBy.TabIndex = 2;
            this.CBFindBy.SelectedIndexChanged += new System.EventHandler(this.CBFindBy_SelectedIndexChanged);
            // 
            // TBFindBy
            // 
            this.TBFindBy.Location = new System.Drawing.Point(294, 36);
            this.TBFindBy.Name = "TBFindBy";
            this.TBFindBy.Size = new System.Drawing.Size(100, 20);
            this.TBFindBy.TabIndex = 3;
            this.TBFindBy.TextChanged += new System.EventHandler(this.TBFindBy_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find by";
            // 
            // BtnFindBy
            // 
            this.BtnFindBy.Location = new System.Drawing.Point(333, 102);
            this.BtnFindBy.Name = "BtnFindBy";
            this.BtnFindBy.Size = new System.Drawing.Size(75, 23);
            this.BtnFindBy.TabIndex = 6;
            this.BtnFindBy.Text = "Find";
            this.BtnFindBy.UseVisualStyleBackColor = true;
            this.BtnFindBy.Click += new System.EventHandler(this.BtnFindBy_Click);
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(444, 36);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 7;
            // 
            // ctrlFindClient1
            // 
            this.ctrlFindClient1.Location = new System.Drawing.Point(-1, 209);
            this.ctrlFindClient1.Name = "ctrlFindClient1";
            this.ctrlFindClient1.Size = new System.Drawing.Size(789, 351);
            this.ctrlFindClient1.TabIndex = 0;
            this.ctrlFindClient1.Load += new System.EventHandler(this.ctrlFindClient1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // FrmFindClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.BtnFindBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBFindBy);
            this.Controls.Add(this.CBFindBy);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.ctrlFindClient1);
            this.Name = "FrmFindClient";
            this.Text = "FrmFindClient";
            this.Load += new System.EventHandler(this.FrmFindClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtrlFindClient ctrlFindClient1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ComboBox CBFindBy;
        private System.Windows.Forms.TextBox TBFindBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFindBy;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}