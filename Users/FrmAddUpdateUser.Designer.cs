namespace Bank.Users
{
    partial class FrmAddUpdateUser
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
            this.SetImageBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DTPBirth = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MainLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBAccountNumber = new System.Windows.Forms.TextBox();
            this.TBAccountBalance = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.CBCurrency = new System.Windows.Forms.ComboBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SetImageBtn
            // 
            this.SetImageBtn.Location = new System.Drawing.Point(948, 355);
            this.SetImageBtn.Name = "SetImageBtn";
            this.SetImageBtn.Size = new System.Drawing.Size(75, 23);
            this.SetImageBtn.TabIndex = 53;
            this.SetImageBtn.Text = "Set Image";
            this.SetImageBtn.UseVisualStyleBackColor = true;
            this.SetImageBtn.Click += new System.EventHandler(this.SetImageBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(831, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // DTPBirth
            // 
            this.DTPBirth.Location = new System.Drawing.Point(270, 378);
            this.DTPBirth.Name = "DTPBirth";
            this.DTPBirth.Size = new System.Drawing.Size(200, 20);
            this.DTPBirth.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Account Number";
            // 
            // MainLbl
            // 
            this.MainLbl.AutoSize = true;
            this.MainLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.MainLbl.Location = new System.Drawing.Point(271, 25);
            this.MainLbl.Name = "MainLbl";
            this.MainLbl.Size = new System.Drawing.Size(447, 76);
            this.MainLbl.TabIndex = 48;
            this.MainLbl.Text = "Frm Add User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Currency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Account Balance";
            // 
            // TBAccountNumber
            // 
            this.TBAccountNumber.Location = new System.Drawing.Point(270, 202);
            this.TBAccountNumber.Name = "TBAccountNumber";
            this.TBAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.TBAccountNumber.TabIndex = 43;
            // 
            // TBAccountBalance
            // 
            this.TBAccountBalance.Location = new System.Drawing.Point(270, 258);
            this.TBAccountBalance.Name = "TBAccountBalance";
            this.TBAccountBalance.Size = new System.Drawing.Size(100, 20);
            this.TBAccountBalance.TabIndex = 42;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(270, 322);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 41;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(270, 154);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 40;
            // 
            // CBCurrency
            // 
            this.CBCurrency.FormattingEnabled = true;
            this.CBCurrency.Location = new System.Drawing.Point(270, 435);
            this.CBCurrency.Name = "CBCurrency";
            this.CBCurrency.Size = new System.Drawing.Size(121, 21);
            this.CBCurrency.TabIndex = 39;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(690, 496);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 55;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(811, 496);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 54;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // FrmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 595);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SetImageBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DTPBirth);
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
            this.Name = "FrmAddUpdateUser";
            this.Text = "FrmAddUpdateUser";
            this.Load += new System.EventHandler(this.FrmAddUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetImageBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DTPBirth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MainLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBAccountNumber;
        private System.Windows.Forms.TextBox TBAccountBalance;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.ComboBox CBCurrency;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}