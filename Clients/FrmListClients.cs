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

    public partial class FrmListClients : Form
    { 
        public FrmListClients()
        {
            InitializeComponent();
        }

        private void Clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void FrmListClients_Load(object sender, EventArgs e)
        {
           
             
            Clients.DataSource = ClsClientBus.GetAllClients();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddUpdateClient addUpdateClient = new FrmAddUpdateClient();
            addUpdateClient.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private bool DeleteTransfer(int ClientID)
        {
            return ClsTransferBus.DeleteTransfer(ClientID);
        }
        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You want to delete this client", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteTransfer(Convert.ToInt32(Clients.CurrentRow.Cells[0].Value));

                if (ClsClientBus.DeleteClient(Convert.ToInt32(Clients.CurrentRow.Cells[1].Value)))
                {

                    MessageBox.Show("Clients has been deleted Successfully");
                    Clients.Refresh();



                }
                else { MessageBox.Show("error"); }
            }
        }
        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateClient updateClient = new FrmAddUpdateClient(Convert.ToInt32(Clients.CurrentRow.Cells[1].Value));
            updateClient.ShowDialog();
        }

        private void findClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFindClient frmFindClient=new FrmFindClient(Convert.ToInt16(Clients.CurrentRow.Cells[1].Value));
            frmFindClient.ShowDialog();
        }

        private void setAsUserToolStripMenuItem_Click(object sender, EventArgs e)
        {ClsPersonBus person=ClsPersonBus.GetPersonBy(Convert.ToInt32(Clients.CurrentRow.Cells[1].Value));
            ClsUserBus user=new ClsUserBus();
            user.Name = person.Name;
            user.Password = person.Password;
            user.AccountNumber = person.AccountNumber;
            user.AccountBalance = person.AccountBalance;
            user.ImagePath = person.ImagePath;
            user.DateOfBirth = person.DateOfBirth;

            if (user.Save())
            {
                MessageBox.Show("User Has Been added successfully");
            }
            else { MessageBox.Show("error"); }

        }

     

        private void depositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepositeWithdraw frmDeposite=new FrmDepositeWithdraw(Convert.ToInt32(Clients.CurrentRow.Cells[1].Value),0);
            frmDeposite.ShowDialog(); 
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepositeWithdraw frmDepositeWithdraw=new FrmDepositeWithdraw(Convert.ToInt32(Clients.CurrentRow.Cells[1].Value), 1);

            frmDepositeWithdraw.ShowDialog();
        }

  

        private void exitToolStripMenuItem_Click_2(object sender, EventArgs e)
        {this.Hide();

        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransferMoney frmTransferMoney = new FrmTransferMoney(Convert.ToInt32(Clients.CurrentRow.Cells[1].Value));
            frmTransferMoney.ShowDialog();
        }
    }
}
