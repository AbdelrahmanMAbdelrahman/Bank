namespace Bank
{
    partial class HomeScreen
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
            this.btnCurrency = new System.Windows.Forms.Button();
            this.BtnClients = new System.Windows.Forms.Button();
            this.UsersBtn = new System.Windows.Forms.Button();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCurrency
            // 
            this.btnCurrency.Location = new System.Drawing.Point(118, 55);
            this.btnCurrency.Name = "btnCurrency";
            this.btnCurrency.Size = new System.Drawing.Size(75, 23);
            this.btnCurrency.TabIndex = 0;
            this.btnCurrency.Text = "Currency";
            this.btnCurrency.UseVisualStyleBackColor = true;
            this.btnCurrency.Click += new System.EventHandler(this.btnCurrency_Click);
            // 
            // BtnClients
            // 
            this.BtnClients.Location = new System.Drawing.Point(385, 55);
            this.BtnClients.Name = "BtnClients";
            this.BtnClients.Size = new System.Drawing.Size(75, 23);
            this.BtnClients.TabIndex = 1;
            this.BtnClients.Text = "Clients";
            this.BtnClients.UseVisualStyleBackColor = true;
            this.BtnClients.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // UsersBtn
            // 
            this.UsersBtn.Location = new System.Drawing.Point(660, 55);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(75, 23);
            this.UsersBtn.TabIndex = 2;
            this.UsersBtn.Text = "Users";
            this.UsersBtn.UseVisualStyleBackColor = true;
            this.UsersBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // TransferBtn
            // 
            this.TransferBtn.Location = new System.Drawing.Point(1089, 55);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(75, 23);
            this.TransferBtn.TabIndex = 3;
            this.TransferBtn.Text = "Transfers";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100.25F);
            this.label1.Location = new System.Drawing.Point(254, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(774, 153);
            this.label1.TabIndex = 4;
            this.label1.Text = "Home Page";
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 766);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.UsersBtn);
            this.Controls.Add(this.BtnClients);
            this.Controls.Add(this.btnCurrency);
            this.Name = "HomeScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCurrency;
        private System.Windows.Forms.Button BtnClients;
        private System.Windows.Forms.Button UsersBtn;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.Label label1;
    }
}

