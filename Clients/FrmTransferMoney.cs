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

namespace Bank.Clients
{
    public partial class FrmTransferMoney : Form
    {
        int _PersonToID;
        int _PersonFromID;
        public FrmTransferMoney(int ClientFromID)
        {
            _PersonFromID = ClientFromID;
            InitializeComponent();
        }

        private void ctrlFindClient1_Load(object sender, EventArgs e)
        {
            
        }
        private int FindPersonID()
        {
            ClsPersonBus person = new ClsPersonBus();
            switch (CBFindBy.Text)
            {
                case "Person ID":
                    person = ClsPersonBus.GetPersonBy(Convert.ToInt32(TBFindBy.Text));

                    break;
                case "Account Number":
                    person = ClsPersonBus.GetPersonBy(TBFindBy.Text.Trim());
                    break;
                case "Name And Password":
                    string Password = ClsPersonBus.EncriptText(TBPassword.Text.Trim());
                    person = ClsPersonBus.GetPersonBy(TBFindBy.Text.Trim(), Password);
                    break;
            }
            if (person != null)
            {
                return person.PersonID;
            }
            else { return 0; }
        }

        private void BtnFindBy_Click(object sender, EventArgs e)
        {_PersonToID=FindPersonID();
            ctrlFindClient1.LoadInfo(_PersonToID);
        }

       
        private bool AddNewTransfer()
        {
            ClsTransferBus transferBus = new ClsTransferBus();
            transferBus.ClientFromID = _PersonFromID;
            transferBus.ClientToID = _PersonToID;
            ClsCurrencyBus currencyBus = new ClsCurrencyBus();
            currencyBus = ClsCurrencyBus.GetCurrencyBy(CBCurrency.Text);
            float AmountInDollar=Convert.ToSingle( TBAmount.Text.Trim())*currencyBus.CurrencyInDollar;
            transferBus.AmountInDollar = AmountInDollar;
            transferBus.TransferDate= DateTime.Now;
            
            transferBus.TransferByUserID =ClsGlobal.CurPerson.PersonID;
            return transferBus.AddNewTransfer();
        }
        private float Deposite()
        {
            float Total = 0;
            if (this.ValidateChildren())
            {
                ClsPersonBus person = ClsPersonBus.GetClientBy(_PersonToID);
                ClsCurrencyBus currencyBase = new ClsCurrencyBus();
                  currencyBase = ClsCurrencyBus.GetCurrencyBy(person.CurrencyID);
                ClsCurrencyBus currencyAdded = new ClsCurrencyBus();
                  currencyAdded = ClsCurrencyBus.GetCurrencyBy(CBCurrency.Text.Trim());

                if (currencyBase.CurrencyInDollar == currencyAdded.CurrencyInDollar)
                {
                    Total = person.AccountBalance + Convert.ToSingle(TBAmount.Text);
                    return Total;
                }
                else
                {
                    float AmountInDollar = Convert.ToSingle(TBAmount.Text) * currencyAdded.CurrencyInDollar;
                    float AmountInClientCurrency = AmountInDollar / currencyBase.CurrencyInDollar;
                    Total = AmountInClientCurrency + person.AccountBalance;
                    return Total;

                }  }return Total;

            }

        //public float Withdraw()
        //{
        //    float Total = 0;
        //    if (this.ValidateChildren())
        //    {
        //        ClsPersonBus person = ClsPersonBus.GetClientBy(_PersonFromID);
        //        ClsCurrencyBus currencyBase=new ClsCurrencyBus();
        //         currencyBase = ClsCurrencyBus.GetCurrencyBy(person.CurrencyID);
        //        ClsCurrencyBus currencyAdded = new ClsCurrencyBus();
        //          currencyAdded = ClsCurrencyBus.GetCurrencyBy(CBCurrency.Text.Trim());
        //        if (currencyBase.CurrencyInDollar == currencyAdded.CurrencyInDollar)
        //        {
        //            if (Convert.ToSingle(TBAmount.Text) < person.AccountBalance)
        //            {
        //                Total = person.AccountBalance - Convert.ToSingle(TBAmount.Text);
        //                return Total;
        //            }
        //            else { MessageBox.Show("No Enough balance"); return 0; }
        //        }
        //        else
        //        {
        //            float AmountInDollar = Convert.ToSingle(TBAmount.Text) * currencyAdded.CurrencyInDollar;
        //            float AmountInClientCurrency = AmountInDollar / currencyBase.CurrencyInDollar;
        //            if (AmountInClientCurrency < person.AccountBalance)
        //            {
        //                Total = person.AccountBalance - AmountInClientCurrency;
        //                return Total;
        //            }
        //            else { MessageBox.Show("No Enough balance"); return 0; }

        //        }

        //    } return Total;
        //}
        
    
        //private bool WithdrawMoney()
        //{
        //    float TotalFrom = Withdraw();
        //    if (TotalFrom > 0)
        //    {
        //        if (ClsPersonBus.DepositeAndWithdraw(_PersonFromID,TotalFrom))
        //        {
        //            return true;
        //        }
        //    }return false;
        //    }
        //private bool DepositeMoney()
        //{
        //    float TotalTo = Deposite();
        //    if (TotalTo > 0)
        //    {
        //        if (ClsPersonBus.DepositeAndWithdraw(_PersonToID, TotalTo))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        private bool TransactMoney()
        {
            return ClsPersonBus.DepositeAndWithdraw(_PersonFromID,_PersonToID,
                Convert.ToInt32(TBAmount.Text),DateTime.Now,ClsGlobal.CurPerson.PersonID);
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
             
                            MessageBox.Show(TransactMoney()? "Transfer Has Been Done Successfully":"error");

                        }
                         
                    else
                    {
                        MessageBox.Show("error transfer to"); return;

                    }
                 
            
        }

        private void FrmTransferMoney_Load(object sender, EventArgs e)
        {
            CBFindBy.Items.Add("Person ID");
            CBFindBy.Items.Add("Account Number");
            CBFindBy.Items.Add("Name And Password");
            TBFindBy.Enabled = false;
            TBPassword.Enabled = false;
            CBCurrency.DataSource = ClsCurrencyBus.GetAllCurrencies();
            CBCurrency.DisplayMember = "CurrencyName";
        }

        private void CacelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CBFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBFindBy.Enabled = true;
            TBPassword.Enabled=true;
        }
    }
}
