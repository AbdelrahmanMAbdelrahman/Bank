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
    public partial class FrmListCurrency : Form
    {
        public FrmListCurrency()
        {
            InitializeComponent();
        }

        //private void Currencies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void FrmListCurrency_Load(object sender, EventArgs e)
        {
            Currencies.DataSource = ClsCurrencyBus.GetAllCurrencies();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddUpdateCurrency addUpdateCurrency = new FrmAddUpdateCurrency();
            addUpdateCurrency.ShowDialog();
        }

        private void Currencies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateCurrency addUpdateCurrency = new
                FrmAddUpdateCurrency(Convert.ToInt32(Convert.ToInt32(Currencies.CurrentRow.Cells[0].Value)));
            addUpdateCurrency.ShowDialog();
        }

        private void findCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFindCurrency findCurrency = new FrmFindCurrency(Convert.ToInt32(Currencies.CurrentRow.Cells[0].Value));
            findCurrency.ShowDialog();
        }

        private void deleteCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You want to delete this Currency", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ClsCurrencyBus.DeleteCurrecny(Convert.ToInt32(Currencies.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Currency has been deleted Succesfully");
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show("error");

                }
            }
        }
    }
}
