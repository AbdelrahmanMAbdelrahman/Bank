namespace Bank.Clients
{
    partial class FrmAddUpdateClient
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
            this.CBCurrency = new System.Windows.Forms.ComboBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBAccountBalance = new System.Windows.Forms.TextBox();
            this.TBAccountNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MainLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.DTPBirth = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SetImageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBCurrency
            // 
            this.CBCurrency.FormattingEnabled = true;
            this.CBCurrency.Location = new System.Drawing.Point(212, 433);
            this.CBCurrency.Name = "CBCurrency";
            this.CBCurrency.Size = new System.Drawing.Size(121, 21);
            this.CBCurrency.TabIndex = 0;
            this.CBCurrency.SelectedIndexChanged += new System.EventHandler(this.CBCurrency_SelectedIndexChanged);
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(212, 152);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 1;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(212, 320);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 6;
            // 
            // TBAccountBalance
            // 
            this.TBAccountBalance.Location = new System.Drawing.Point(212, 256);
            this.TBAccountBalance.Name = "TBAccountBalance";
            this.TBAccountBalance.Size = new System.Drawing.Size(100, 20);
            this.TBAccountBalance.TabIndex = 7;
            // 
            // TBAccountNumber
            // 
            this.TBAccountNumber.Location = new System.Drawing.Point(212, 200);
            this.TBAccountNumber.Name = "TBAccountNumber";
            this.TBAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.TBAccountNumber.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Account Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Currency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password";
            // 
            // MainLbl
            // 
            this.MainLbl.AutoSize = true;
            this.MainLbl.Location = new System.Drawing.Point(448, 45);
            this.MainLbl.Name = "MainLbl";
            this.MainLbl.Size = new System.Drawing.Size(75, 13);
            this.MainLbl.TabIndex = 15;
            this.MainLbl.Text = "Frm Add Client";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Account Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Name";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(569, 562);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 18;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(448, 562);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 19;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // DTPBirth
            // 
            this.DTPBirth.Location = new System.Drawing.Point(212, 376);
            this.DTPBirth.Name = "DTPBirth";
            this.DTPBirth.Size = new System.Drawing.Size(200, 20);
            this.DTPBirth.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(773, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // SetImageBtn
            // 
            this.SetImageBtn.Location = new System.Drawing.Point(890, 353);
            this.SetImageBtn.Name = "SetImageBtn";
            this.SetImageBtn.Size = new System.Drawing.Size(75, 23);
            this.SetImageBtn.TabIndex = 23;
            this.SetImageBtn.Text = "Set Image";
            this.SetImageBtn.UseVisualStyleBackColor = true;
            this.SetImageBtn.Click += new System.EventHandler(this.SetImageBtn_Click);
            // 
            // FrmAddUpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 675);
            this.Controls.Add(this.SetImageBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DTPBirth);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MainLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBAccountNumber);
            this.Controls.Add(this.TBAccountBalance);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.CBCurrency);
            this.Name = "FrmAddUpdateClient";
            this.Text = "FrmAddUpdateClient";
            this.Load += new System.EventHandler(this.FrmAddUpdateClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBCurrency;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBAccountBalance;
        private System.Windows.Forms.TextBox TBAccountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MainLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.DateTimePicker DTPBirth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SetImageBtn;
    }
}