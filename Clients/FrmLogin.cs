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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //  ClsPersonBus person=ClsPersonBus.GetPersonBy(TBName.Text,TbPassword.Text);
            string password = TbPassword.Text;
            ClsPersonBus person
                = ClsUserBus.GetUserBy(TBName.Text, password);
            if (person != null) { 
            
                ClsGlobal.CurPerson = person;
                this.Hide();
                HomeScreen homeScreen = new HomeScreen();
                homeScreen.Show();
            }
            else { MessageBox.Show("User not Exist"); }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TBName.Text = "abdo";
            TbPassword.Text = "done";
        }
    }
}
