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
    public partial class FrmFindCurrency : Form
    {
        int _CurrencyID = 0;
        ClsCurrencyBus _currency;
        public FrmFindCurrency(int CurrencyID)
        {
            _CurrencyID = CurrencyID;
            InitializeComponent();
        }

        private void FrmFindCurrency_Load(object sender, EventArgs e)
        {
            _currency = ClsCurrencyBus.GetCurrencyBy(_CurrencyID);
            CurrencyIDLbl.Text = _currency.CurrencyID.ToString() ;
            CurrencyInDollar.Text=_currency.CurrencyInDollar.ToString() ;
            CurrencyName.Text=_currency.CurrencyName.ToString() ;
            CBFindBy.Items.Add("Currency ID");
            CBFindBy.Items.Add("Currency Name");
            TBFindBy.Enabled = false;

        }

        private void CBFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBFindBy.Enabled=true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (TBFindBy.Text != "")
            {
                switch (CBFindBy.Text)
                {
                    case "Currency ID":
                        _currency = ClsCurrencyBus.GetCurrencyBy(Convert.ToInt32(TBFindBy.Text));
                        CurrencyIDLbl.Text = _currency.CurrencyID.ToString();
                        CurrencyInDollar.Text = _currency.CurrencyInDollar.ToString();
                        CurrencyName.Text = _currency.CurrencyName.ToString(); break;
                    case "Currency Name":
                        _currency = ClsCurrencyBus.GetCurrencyBy(TBFindBy.Text);
                        CurrencyIDLbl.Text = _currency.CurrencyID.ToString();
                        CurrencyInDollar.Text = _currency.CurrencyInDollar.ToString();
                        CurrencyName.Text = _currency.CurrencyName.ToString();
                        break;
                }
            }
        }
    }
}
