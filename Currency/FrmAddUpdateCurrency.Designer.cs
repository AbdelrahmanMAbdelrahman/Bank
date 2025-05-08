namespace Bank.Currency
{
    partial class FrmAddUpdateCurrency
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
            this.ScreenLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrencyLbl = new System.Windows.Forms.Label();
            this.CurrencyNameTB = new System.Windows.Forms.TextBox();
            this.CurrencyInDollarTB = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScreenLbl
            // 
            this.ScreenLbl.AutoSize = true;
            this.ScreenLbl.Location = new System.Drawing.Point(324, 41);
            this.ScreenLbl.Name = "ScreenLbl";
            this.ScreenLbl.Size = new System.Drawing.Size(97, 13);
            this.ScreenLbl.TabIndex = 0;
            this.ScreenLbl.Text = "form Add Currency ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Currency ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Currency Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Currency In Dollar";
            // 
            // CurrencyLbl
            // 
            this.CurrencyLbl.AutoSize = true;
            this.CurrencyLbl.Location = new System.Drawing.Point(360, 148);
            this.CurrencyLbl.Name = "CurrencyLbl";
            this.CurrencyLbl.Size = new System.Drawing.Size(19, 13);
            this.CurrencyLbl.TabIndex = 4;
            this.CurrencyLbl.Text = "??";
            // 
            // CurrencyNameTB
            // 
            this.CurrencyNameTB.Location = new System.Drawing.Point(378, 198);
            this.CurrencyNameTB.Name = "CurrencyNameTB";
            this.CurrencyNameTB.Size = new System.Drawing.Size(100, 20);
            this.CurrencyNameTB.TabIndex = 5;
            // 
            // CurrencyInDollarTB
            // 
            this.CurrencyInDollarTB.Location = new System.Drawing.Point(378, 255);
            this.CurrencyInDollarTB.Name = "CurrencyInDollarTB";
            this.CurrencyInDollarTB.Size = new System.Drawing.Size(100, 20);
            this.CurrencyInDollarTB.TabIndex = 6;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(251, 317);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(403, 317);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmAddUpdateCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 477);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.CurrencyInDollarTB);
            this.Controls.Add(this.CurrencyNameTB);
            this.Controls.Add(this.CurrencyLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScreenLbl);
            this.Name = "FrmAddUpdateCurrency";
            this.Text = "FrmAddUpdateCurrency";
            this.Load += new System.EventHandler(this.FrmAddUpdateCurrency_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScreenLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CurrencyLbl;
        private System.Windows.Forms.TextBox CurrencyNameTB;
        private System.Windows.Forms.TextBox CurrencyInDollarTB;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
    }
}