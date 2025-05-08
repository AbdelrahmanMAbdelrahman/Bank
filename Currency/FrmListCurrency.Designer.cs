namespace Bank.Currency
{
    partial class FrmListCurrency
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
            this.components = new System.ComponentModel.Container();
            this.Currencies = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.findCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Currencies)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Currencies
            // 
            this.Currencies.AllowUserToAddRows = false;
            this.Currencies.AllowUserToDeleteRows = false;
            this.Currencies.AllowUserToOrderColumns = true;
            this.Currencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Currencies.Location = new System.Drawing.Point(0, 178);
            this.Currencies.Name = "Currencies";
            this.Currencies.ReadOnly = true;
            this.Currencies.Size = new System.Drawing.Size(1099, 520);
            this.Currencies.TabIndex = 0;
            this.Currencies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Currencies_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New Currency";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findCurrencyToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteCurrencyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 92);
            // 
            // findCurrencyToolStripMenuItem
            // 
            this.findCurrencyToolStripMenuItem.Name = "findCurrencyToolStripMenuItem";
            this.findCurrencyToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.findCurrencyToolStripMenuItem.Text = "Find Currency";
            this.findCurrencyToolStripMenuItem.Click += new System.EventHandler(this.findCurrencyToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.updateToolStripMenuItem.Text = "Update Currency";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteCurrencyToolStripMenuItem
            // 
            this.deleteCurrencyToolStripMenuItem.Name = "deleteCurrencyToolStripMenuItem";
            this.deleteCurrencyToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteCurrencyToolStripMenuItem.Text = "Delete Currency";
            this.deleteCurrencyToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrencyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FrmListCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 696);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Currencies);
            this.Name = "FrmListCurrency";
            this.Text = "FrmListCurrency";
            this.Load += new System.EventHandler(this.FrmListCurrency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Currencies)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Currencies;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findCurrencyToolStripMenuItem;
    }
}