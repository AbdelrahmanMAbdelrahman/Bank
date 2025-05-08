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

namespace Bank.Users
{
    public partial class FrmAddUpdateUser : Form
    {public enum enMode { addNew=0,update=1}
        public enMode mode = enMode.addNew;
        string _ImagePath = "";
        int _PrsonID = 0;
        ClsPersonBus _person;
        public FrmAddUpdateUser()
        {
            mode = enMode.addNew;
            InitializeComponent();
        }

        public FrmAddUpdateUser(int PersonID)
        {
            _PrsonID = PersonID;

            mode = enMode.update;
            InitializeComponent();

        }
        private void FrmAddUpdateUser_Load(object sender, EventArgs e)
        {
            CBCurrency.DataSource = ClsCurrencyBus.GetAllCurrencies();
            CBCurrency.DisplayMember = "CurrencyName";
            if (mode == enMode.update)
            {
                MainLbl.Text = "update user";LoadPersonInfo();

            }
        }
        private void LoadPersonInfo()
        {
          _person=ClsPersonBus.GetPersonBy(_PrsonID);
            TBAccountBalance.Text =_person.AccountBalance.ToString();
            TBAccountNumber.Text = _person.AccountNumber.ToString();
            TBName.Text = _person.Name.ToString();
            TBPassword.Text = _person.Password;
            DTPBirth.Text=_person.DateOfBirth.ToString();
            ClsCurrencyBus currency = ClsCurrencyBus.GetCurrencyBy(_person.CurrencyID);
            if (_person.ImagePath != null) { 
            pictureBox1.ImageLocation=_person.ImagePath;
            }
        }
        private void SetImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files |*.png;*.bmp;*.gif;*.jpeg;*.jpg";
            openFileDialog.Title = "select image";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _ImagePath = openFileDialog.FileName;
                pictureBox1.ImageLocation = _ImagePath;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {if (mode == enMode.addNew)
            {
                ClsPersonBus person = ClsPersonBus.GetPersonBy(TBAccountNumber.Text);
                if (person == null)
                {
                    ClsUserBus user = new ClsUserBus();
                    user.Name = TBName.Text;
                    user.Name = TBName.Text;
                    user.Password = TBPassword.Text;
                    user.AccountNumber = TBAccountNumber.Text;
                    user.AccountBalance = Convert.ToSingle(TBAccountBalance.Text);
                    user.DateOfBirth=DTPBirth.Value;
                    if (ClsClientBus.HandlePersonImage(ref _ImagePath))
                    {
                        user.ImagePath = _ImagePath;
                    }
                    else { user.ImagePath = ""; }
                    user.DateOfBirth = DTPBirth.Value;
                    ClsCurrencyBus currency = ClsCurrencyBus.GetCurrencyBy(CBCurrency.Text.Trim());
                    user.CurrencyID = currency.CurrencyID;

                    if (user.Save())
                    {
                        MessageBox.Show("Clients Has Been Added Successfully");
                        SaveBtn.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("error");

                    }
                }
                else
                {
                    MessageBox.Show("Person Already is a Client");
                }
            }
            else
            {
                ClsPersonBus person = ClsPersonBus.GetPersonBy(_PrsonID);
                person.Name = TBName.Text;
                if (ClsPersonBus.HandlePersonImage(ref _ImagePath))
                {
                    person.ImagePath = _ImagePath;
                }
                person.Password=TBPassword.Text;
                person.AccountBalance=Convert.ToSingle(TBAccountBalance.Text);
                person.AccountNumber = TBAccountNumber.Text;
                person.DateOfBirth=DTPBirth.Value;
                ClsCurrencyBus currency=ClsCurrencyBus.GetCurrencyBy(CBCurrency.Text);
                person.CurrencyID = currency.CurrencyID;
                if (person.Save()) {
                    MessageBox.Show("User has been updated Successfully");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
