using Bank.Clients;
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
    public partial class FrmListUsers : Form
    {
        public FrmListUsers()
        {
            InitializeComponent();
        }

        private void FrmListUsers_Load(object sender, EventArgs e)
        {
            users.DataSource = ClsUserBus.GetAllUsers();
        }

        private void Clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            FrmAddUpdateUser frmAddUpdateUser = new FrmAddUpdateUser();
            frmAddUpdateUser.ShowDialog();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to delete this User", "delet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ClsUserBus.DeleteUser(Convert.ToInt32(users.CurrentRow.Cells[1].Value)))
                {
                    MessageBox.Show("User Has Been deleted Succesffully");
                    users.Refresh();
                    this.Refresh();
                }
                else { MessageBox.Show("error"); }
            }
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateUser frmAddUpdateUser = new FrmAddUpdateUser(Convert.ToInt32(users.CurrentRow.Cells[1].Value));
            frmAddUpdateUser.ShowDialog();
        }

        private void findUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFindClient frmFindClient = new FrmFindClient(Convert.ToInt16(users.CurrentRow.Cells[1].Value));
            frmFindClient.ShowDialog();
        }
    }
}
