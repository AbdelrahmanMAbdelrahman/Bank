using BankBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Clients
{
    public partial class FrmDepositeWithdraw : Form
    {
        string _Operation = "Deposited";
        enum enControlBalance { deposite = 0, withdraw = 1 }
        enControlBalance _controlBalance = enControlBalance.deposite;
        int _personID = 0;
        public FrmDepositeWithdraw(int personID, int ControlBalance)
        {
            _controlBalance = (enControlBalance)ControlBalance;
            _personID = personID;
            InitializeComponent();
        }

        private void ctrlFindClient1_Load(object sender, EventArgs e)
        {

        }

        private void FrmDeposite_Load(object sender, EventArgs e)
        {
            ctrlFindClient1.LoadInfo(_personID);
            CBCurrency.DataSource = ClsCurrencyBus.GetAllCurrencies();
            CBCurrency.DisplayMember = "CurrencyName";
            if (_controlBalance == enControlBalance.withdraw) {
                MainLbl.Text = "Withdraw Screen";
                _Operation = "withdrawed";
            }
        }

        private void CBCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DepositeBtn_Click(object sender, EventArgs e)
        {
            float Total = 0;
            if (this.ValidateChildren())
            {
                ClsPersonBus person = ClsPersonBus.GetClientBy(_personID);
                ClsCurrencyBus currencyBase = ClsCurrencyBus.GetCurrencyBy(person.CurrencyID);
                ClsCurrencyBus currencyAdded = ClsCurrencyBus.GetCurrencyBy(CBCurrency.Text.Trim());
                if (_controlBalance == enControlBalance.deposite)
                {
                    if (currencyBase.CurrencyInDollar == currencyAdded.CurrencyInDollar)
                    {
                        Total = person.AccountBalance + Convert.ToSingle(TBAmount.Text);
                    }
                    else
                    {
                        float AmountInDollar = Convert.ToSingle(TBAmount.Text) * currencyAdded.CurrencyInDollar;
                        float AmountInClientCurrency = AmountInDollar / currencyBase.CurrencyInDollar;
                        Total = AmountInClientCurrency + person.AccountBalance;
                    }
                }
                else
                {
                    if (currencyBase.CurrencyInDollar == currencyAdded.CurrencyInDollar)
                    {
                        if (Convert.ToSingle(TBAmount.Text) < person.AccountBalance)
                        {
                            Total = person.AccountBalance - Convert.ToSingle(TBAmount.Text);
                        }
                        else { MessageBox.Show("No Enough balance"); return; }
                    }
                    else
                    {
                        float AmountInDollar = Convert.ToSingle(TBAmount.Text) * currencyAdded.CurrencyInDollar;
                        float AmountInClientCurrency = AmountInDollar / currencyBase.CurrencyInDollar;
                        if (AmountInClientCurrency < person.AccountBalance)
                        {
                            Total = person.AccountBalance - AmountInClientCurrency;
                        }
                        else { MessageBox.Show("No Enough balance"); return; }

                    }

                }


            }
            //if (ClsPersonBus.DepositeAndWithdraw(_personID, Total))
            //{
            //    MessageBox.Show($"Account has been {_Operation} Successfully");
            //    SaveBtn.Enabled = false;
            //}
            //else { MessageBox.Show("error"); }
        
    }
    }
}
