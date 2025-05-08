namespace Bank.Clients
{
    partial class FrmTransferMoney
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CacelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBCurrency = new System.Windows.Forms.ComboBox();
            this.TBAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BtnFindBy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TBFindBy = new System.Windows.Forms.TextBox();
            this.CBFindBy = new System.Windows.Forms.ComboBox();
            this.ctrlFindClient1 = new Bank.Clients.CtrlFindClient();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(737, 627);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CacelBtn
            // 
            this.CacelBtn.Location = new System.Drawing.Point(607, 627);
            this.CacelBtn.Name = "CacelBtn";
            this.CacelBtn.Size = new System.Drawing.Size(75, 23);
            this.CacelBtn.TabIndex = 11;
            this.CacelBtn.Text = "Cancel";
            this.CacelBtn.UseVisualStyleBackColor = true;
            this.CacelBtn.Click += new System.EventHandler(this.CacelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Currency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Amount";
            // 
            // CBCurrency
            // 
            this.CBCurrency.FormattingEnabled = true;
            this.CBCurrency.Location = new System.Drawing.Point(516, 569);
            this.CBCurrency.Name = "CBCurrency";
            this.CBCurrency.Size = new System.Drawing.Size(121, 21);
            this.CBCurrency.TabIndex = 8;
            // 
            // TBAmount
            // 
            this.TBAmount.Location = new System.Drawing.Point(252, 574);
            this.TBAmount.Name = "TBAmount";
            this.TBAmount.Size = new System.Drawing.Size(100, 20);
            this.TBAmount.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name";
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(537, 65);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 17;
            // 
            // BtnFindBy
            // 
            this.BtnFindBy.Location = new System.Drawing.Point(401, 118);
            this.BtnFindBy.Name = "BtnFindBy";
            this.BtnFindBy.Size = new System.Drawing.Size(75, 23);
            this.BtnFindBy.TabIndex = 16;
            this.BtnFindBy.Text = "Find";
            this.BtnFindBy.UseVisualStyleBackColor = true;
            this.BtnFindBy.Click += new System.EventHandler(this.BtnFindBy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Find by";
            // 
            // TBFindBy
            // 
            this.TBFindBy.Location = new System.Drawing.Point(396, 65);
            this.TBFindBy.Name = "TBFindBy";
            this.TBFindBy.Size = new System.Drawing.Size(100, 20);
            this.TBFindBy.TabIndex = 14;
            // 
            // CBFindBy
            // 
            this.CBFindBy.FormattingEnabled = true;
            this.CBFindBy.Location = new System.Drawing.Point(217, 64);
            this.CBFindBy.Name = "CBFindBy";
            this.CBFindBy.Size = new System.Drawing.Size(121, 21);
            this.CBFindBy.TabIndex = 13;
            this.CBFindBy.SelectedIndexChanged += new System.EventHandler(this.CBFindBy_SelectedIndexChanged);
            // 
            // ctrlFindClient1
            // 
            this.ctrlFindClient1.Location = new System.Drawing.Point(71, 182);
            this.ctrlFindClient1.Name = "ctrlFindClient1";
            this.ctrlFindClient1.Size = new System.Drawing.Size(789, 363);
            this.ctrlFindClient1.TabIndex = 0;
            this.ctrlFindClient1.Load += new System.EventHandler(this.ctrlFindClient1_Load);
            // 
            // FrmTransferMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 717);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.BtnFindBy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBFindBy);
            this.Controls.Add(this.CBFindBy);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CacelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBCurrency);
            this.Controls.Add(this.TBAmount);
            this.Controls.Add(this.ctrlFindClient1);
            this.Name = "FrmTransferMoney";
            this.Text = "FrmTransferMoney";
            this.Load += new System.EventHandler(this.FrmTransferMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtrlFindClient ctrlFindClient1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CacelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBCurrency;
        private System.Windows.Forms.TextBox TBAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BtnFindBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBFindBy;
        private System.Windows.Forms.ComboBox CBFindBy;
    }
}