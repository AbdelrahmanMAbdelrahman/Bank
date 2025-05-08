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
    public partial class FrmFindClient : Form
    {
        int _PersonID = 0;
        public FrmFindClient(int personID)
        {
            _PersonID = personID;
            InitializeComponent();
        }

        private void FrmFindClient_Load(object sender, EventArgs e)
        {
            ctrlFindClient1.LoadInfo(_PersonID);
            CBFindBy.Items.Add("Person ID");
            CBFindBy.Items.Add("Account Number");
            CBFindBy.Items.Add("Name And Password");
            TBFindBy.Enabled = false;
            TBPassword.Enabled=false; 
        }
        private int FindPersonID()
        {
            ClsPersonBus person = new ClsPersonBus();
            switch (CBFindBy.Text)
            {
                case "Person ID":person = ClsPersonBus.GetClientBy(Convert.ToInt32(TBFindBy.Text));

                    break;
                case "Account Number":
                    person = ClsPersonBus.GetPersonBy(TBFindBy.Text.Trim());
                    break;
                case "Name And Password":
                //    string Password = ClsPersonBus.EncriptText(TBPassword.Text.Trim());
                    person=ClsPersonBus.GetPersonBy(TBFindBy.Text.Trim(), TBPassword.Text.Trim());
                    break;
            }
            if (person != null) {
                return person.PersonID;
            }
            else { return 0; }
        }
        private void BtnFindBy_Click(object sender, EventArgs e)
        {
            int PersonID = FindPersonID();
            if (PersonID != 0)
            {
                ctrlFindClient1.LoadInfo(PersonID);
            }
            else { MessageBox.Show("Client not found"); }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CBFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBFindBy.Enabled = true;
        }

        private void TBFindBy_TextChanged(object sender, EventArgs e)
        {
            TBPassword.Enabled = true;

        }

        private void ctrlFindClient1_Load(object sender, EventArgs e)
        {

        }
    }
}
