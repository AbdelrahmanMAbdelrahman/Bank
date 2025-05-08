using BankBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Currency
{
    public partial class FrmAddUpdateCurrency : Form
    {
        private enum EnMode { addNew = 0, update = 1 }
        private EnMode Mode = EnMode.addNew;
        ClsCurrencyBus _Currency;
        private int _CurrencyID = 0;
        public FrmAddUpdateCurrency()
        {
            Mode = EnMode.addNew;
            // CurrencyLbl.Text = "Form Add New Currency";

            InitializeComponent();
        }
        public FrmAddUpdateCurrency(int CurrencyID)
        {
            _CurrencyID = CurrencyID;
            Mode = EnMode.update;
            InitializeComponent();
            // CurrencyLbl.Text = "Form Update Currency";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                switch (Mode)
                {
                    case EnMode.addNew:
                        _Currency = new ClsCurrencyBus();
                        _Currency.CurrencyInDollar = Convert.ToSingle(CurrencyInDollarTB.Text.Trim());
                        _Currency.CurrencyName = CurrencyNameTB.Text.Trim();
                        if (_Currency.Save())
                        {
                            MessageBox.Show("Currency has been added successfully");
                            Mode = EnMode.update;
                        }
                        else { MessageBox.Show("Currency already exists"); }
                        break;
                    case EnMode.update:
                        if (_CurrencyID != 0)
                        {if (float.TryParse(CurrencyInDollarTB.Text, out float CurrencyInDollar)) {
                                _Currency.CurrencyInDollar = CurrencyInDollar; }
                            _Currency.CurrencyName=CurrencyNameTB.Text.Trim();
                            if (_Currency.Save())
                            {
                                if (MessageBox.Show("Currency has been updated successfully", "SUCCESS",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                                {
                                    this.Refresh();
                                }

                            }
                            else
                            {

                                if (MessageBox.Show("error update the Currecy", "Failure",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                                {
                                    this.Hide();
                                }
                            }
                        }

                        break;
                }
            }
            else { MessageBox.Show("Fill all field"); }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmAddUpdateCurrency_Load(object sender, EventArgs e)
        {
            _Currency = ClsCurrencyBus.GetCurrencyBy(_CurrencyID);
            if (_Currency != null)
            {
                CurrencyInDollarTB.Text = Convert.ToSingle(_Currency.CurrencyInDollar).ToString();
                CurrencyNameTB.Text = _Currency.CurrencyName;
                CurrencyLbl.Text = _Currency.CurrencyID.ToString();
            }
                switch (Mode)
                {
                    case EnMode.update: ScreenLbl.Text = "Update Currency 😎😎"; break;
                    case EnMode.addNew: ScreenLbl.Text = "Add new Currency :-)"; break;
                }
            
          
        }
    }
}
