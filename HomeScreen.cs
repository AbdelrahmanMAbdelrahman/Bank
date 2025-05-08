using Bank.Clients;
using Bank.Currency;
using Bank.Transfers;
using Bank.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }


        private void btnCurrency_Click(object sender, EventArgs e)
        {
            FrmListCurrency frmListCurrency = new FrmListCurrency();
            frmListCurrency.ShowDialog();
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            FrmListClients frmListClients = new FrmListClients();
            frmListClients.ShowDialog();
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            FrmListUsers frmListUsers = new FrmListUsers();
            frmListUsers.ShowDialog();
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            frmTransfer frmTransfer = new frmTransfer();
            frmTransfer.ShowDialog();
        }
    }
}
