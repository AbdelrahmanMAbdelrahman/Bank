namespace Bank.Clients
{
    partial class FrmDepositeWithdraw
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
            this.ctrlFindClient1 = new Bank.Clients.CtrlFindClient();
            this.TBAmount = new System.Windows.Forms.TextBox();
            this.CBCurrency = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CacelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.MainLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlFindClient1
            // 
            this.ctrlFindClient1.Location = new System.Drawing.Point(53, 59);
            this.ctrlFindClient1.Name = "ctrlFindClient1";
            this.ctrlFindClient1.Size = new System.Drawing.Size(789, 363);
            this.ctrlFindClient1.TabIndex = 0;
            this.ctrlFindClient1.Load += new System.EventHandler(this.ctrlFindClient1_Load);
            // 
            // TBAmount
            // 
            this.TBAmount.Location = new System.Drawing.Point(200, 444);
            this.TBAmount.Name = "TBAmount";
            this.TBAmount.Size = new System.Drawing.Size(100, 20);
            this.TBAmount.TabIndex = 1;
            // 
            // CBCurrency
            // 
            this.CBCurrency.FormattingEnabled = true;
            this.CBCurrency.Location = new System.Drawing.Point(464, 439);
            this.CBCurrency.Name = "CBCurrency";
            this.CBCurrency.Size = new System.Drawing.Size(121, 21);
            this.CBCurrency.TabIndex = 2;
            this.CBCurrency.SelectedIndexChanged += new System.EventHandler(this.CBCurrency_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Currency";
            // 
            // CacelBtn
            // 
            this.CacelBtn.Location = new System.Drawing.Point(555, 497);
            this.CacelBtn.Name = "CacelBtn";
            this.CacelBtn.Size = new System.Drawing.Size(75, 23);
            this.CacelBtn.TabIndex = 5;
            this.CacelBtn.Text = "Cancel";
            this.CacelBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(685, 497);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.DepositeBtn_Click);
            // 
            // MainLbl
            // 
            this.MainLbl.AutoSize = true;
            this.MainLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.MainLbl.Location = new System.Drawing.Point(259, 23);
            this.MainLbl.Name = "MainLbl";
            this.MainLbl.Size = new System.Drawing.Size(326, 47);
            this.MainLbl.TabIndex = 7;
            this.MainLbl.Text = "Deposite Screen";
            // 
            // FrmDepositeWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 545);
            this.Controls.Add(this.MainLbl);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CacelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBCurrency);
            this.Controls.Add(this.TBAmount);
            this.Controls.Add(this.ctrlFindClient1);
            this.Name = "FrmDepositeWithdraw";
            this.Text = "FrmDeposite";
            this.Load += new System.EventHandler(this.FrmDeposite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtrlFindClient ctrlFindClient1;
        private System.Windows.Forms.TextBox TBAmount;
        private System.Windows.Forms.ComboBox CBCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CacelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label MainLbl;
    }
}