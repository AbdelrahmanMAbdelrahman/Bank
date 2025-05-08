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
    public partial class FrmAddUpdateClient : Form
    {
        string _ImagePath = "";
        private enum enMode { addNew, update }
        enMode mode = enMode.addNew;

        ClsPersonBus _person;
        int _PersonID = 0;
        ClsClientBus _Client;
        public FrmAddUpdateClient()
        {
            InitializeComponent();
            mode = enMode.addNew;
        }
        public FrmAddUpdateClient(int PersonID)

        {
           
            _PersonID = PersonID;
            mode = enMode.update;
            InitializeComponent();
        }

        private void FrmAddUpdateClient_Load(object sender, EventArgs e)
        {      //Object                    //Data table
            CBCurrency.DataSource = ClsCurrencyBus.GetAllCurrencies();
            CBCurrency.DisplayMember = "CurrencyName";
            if (mode == enMode.update) {
                MainLbl.Text = "form Update Cliant";
                LoadPersonInfo();
            }
        }
        private void LoadPersonInfo()
        {
          _person  =  ClsPersonBus.GetClientBy(_PersonID);
            
            TBName.Text = _person.Name;
            TBPassword.Text =_person.Password;
            TBAccountNumber.Text = _person.AccountNumber;
            TBAccountBalance.Text = _person.AccountBalance.ToString();
            pictureBox1.ImageLocation = _person.ImagePath;
            DTPBirth.Value = _person.DateOfBirth;
            ClsCurrencyBus currency=ClsCurrencyBus.GetCurrencyBy(_person.CurrencyID);
            CBCurrency.Text = currency.CurrencyName;
        }

        private void CBCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (mode == enMode.addNew)
            {
                _Client = new ClsClientBus();
                _Client.Name = TBName.Text;
                _Client.Password = TBPassword.Text;
                _Client.AccountNumber = TBAccountNumber.Text;
                _Client.AccountBalance = Convert.ToSingle(TBAccountBalance.Text);
                if (ClsClientBus.HandlePersonImage(ref _ImagePath))
                {
                    _Client.ImagePath = _ImagePath;
                }
                else { _Client.ImagePath = ""; }
                _Client.DateOfBirth = DTPBirth.Value;
                ClsCurrencyBus currency = ClsCurrencyBus.GetCurrencyBy(CBCurrency.Text.Trim());
                _Client.CurrencyID = currency.CurrencyID;
             
                    if (_Client.Save())
                    {
                        MessageBox.Show("Clients Has Been Added Successfully");
                    SaveBtn.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("error");

                    }

            }
            else { _person=ClsClientBus.GetClientBy(_PersonID);
                _person.Name = TBName.Text;
                _person.Password =TBPassword.Text;
                _person.AccountNumber = TBAccountNumber.Text;
                _person.AccountBalance = Convert.ToSingle(TBAccountBalance.Text);
                if (ClsClientBus.HandlePersonImage(ref _ImagePath))
                {
                    _person.ImagePath = _ImagePath;
                }
                else { _person.ImagePath = "empty value"; }
                _person.DateOfBirth = DTPBirth.Value;
                ClsCurrencyBus currency = ClsCurrencyBus.GetCurrencyBy(CBCurrency.Text.Trim());
                _person.CurrencyID = currency.CurrencyID;
                if (_person.Save())
                {
                    MessageBox.Show("Client has been updated Successfully");
                    SaveBtn.Enabled = false;
                }
                else { MessageBox.Show("error"); }
            }
        }

        private void SetImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog= new OpenFileDialog();
            openFileDialog.Filter = "Image Files |*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            openFileDialog.Title = "select image";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation=openFileDialog.FileName;
                _ImagePath=openFileDialog.FileName;
            }
        }
    }
}
