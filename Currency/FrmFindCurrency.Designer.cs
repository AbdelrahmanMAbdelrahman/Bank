namespace Bank.Currency
{
    partial class FrmFindCurrency
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
            this.CBFindBy = new System.Windows.Forms.ComboBox();
            this.TBFindBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.CurrencyInDollar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrencyName = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.CurrencyIDLbl = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBFindBy
            // 
            this.CBFindBy.FormattingEnabled = true;
            this.CBFindBy.Location = new System.Drawing.Point(167, 28);
            this.CBFindBy.Name = "CBFindBy";
            this.CBFindBy.Size = new System.Drawing.Size(121, 21);
            this.CBFindBy.TabIndex = 0;
            this.CBFindBy.SelectedIndexChanged += new System.EventHandler(this.CBFindBy_SelectedIndexChanged);
            // 
            // TBFindBy
            // 
            this.TBFindBy.Location = new System.Drawing.Point(351, 29);
            this.TBFindBy.Name = "TBFindBy";
            this.TBFindBy.Size = new System.Drawing.Size(100, 20);
            this.TBFindBy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(542, 29);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // CurrencyInDollar
            // 
            this.CurrencyInDollar.AutoSize = true;
            this.CurrencyInDollar.Location = new System.Drawing.Point(200, 309);
            this.CurrencyInDollar.Name = "CurrencyInDollar";
            this.CurrencyInDollar.Size = new System.Drawing.Size(25, 13);
            this.CurrencyInDollar.TabIndex = 4;
            this.CurrencyInDollar.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "currencyInDollar";
            // 
            // CurrencyName
            // 
            this.CurrencyName.AutoSize = true;
            this.CurrencyName.Location = new System.Drawing.Point(200, 219);
            this.CurrencyName.Name = "CurrencyName";
            this.CurrencyName.Size = new System.Drawing.Size(25, 13);
            this.CurrencyName.TabIndex = 6;
            this.CurrencyName.Text = "???";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(86, 219);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(80, 13);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Currency Name";
            // 
            // CurrencyIDLbl
            // 
            this.CurrencyIDLbl.AutoSize = true;
            this.CurrencyIDLbl.Location = new System.Drawing.Point(200, 124);
            this.CurrencyIDLbl.Name = "CurrencyIDLbl";
            this.CurrencyIDLbl.Size = new System.Drawing.Size(25, 13);
            this.CurrencyIDLbl.TabIndex = 8;
            this.CurrencyIDLbl.Text = "???";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(86, 124);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(63, 13);
            this.lbl.TabIndex = 9;
            this.lbl.Text = "Currency ID";
            // 
            // FrmFindCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.CurrencyIDLbl);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.CurrencyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CurrencyInDollar);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBFindBy);
            this.Controls.Add(this.CBFindBy);
            this.Name = "FrmFindCurrency";
            this.Text = "FrmFindCurrency";
            this.Load += new System.EventHandler(this.FrmFindCurrency_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBFindBy;
        private System.Windows.Forms.TextBox TBFindBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label CurrencyInDollar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CurrencyName;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label CurrencyIDLbl;
        private System.Windows.Forms.Label lbl;
    }
}