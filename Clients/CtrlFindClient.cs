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
    public partial class CtrlFindClient : UserControl
    { int _PersonID=0;
        public CtrlFindClient()
        {
           // _PersonID = PersonID;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public  void LoadInfo(int PersonID)
        {
            ClsPersonBus person = ClsPersonBus.GetClientBy(PersonID);
            if(person!=null)
            Namelbl.Text = person.Name;
            PasswordLbl.Text = person.Password;
            AccountBalancelbl.Text = person.AccountBalance.ToString();
            AccountNumberLbl.Text = person.AccountNumber.ToString();
            DateLbl.Text = person.DateOfBirth.ToString();
            if (person.ImagePath != null)
            {
                pictureBox1.ImageLocation = person.ImagePath;
            }
            ClsCurrencyBus currency=ClsCurrencyBus.GetCurrencyBy(person.CurrencyID);
            CurrencyLbl.Text = currency.CurrencyName;
            BalanceELbl.Text = ConvertNumberToString(Convert.ToInt32 (person.AccountBalance));

        }
        private string ConvertNumberToString(int number)
        {
            string NumberInString = "";
            List<string> List1 = new List<string>{ "Zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
            "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty" };
            List<string> List2 = new List<string> {"zero", "ten", "twenty", "thirty", "forty", "fifty",
                "sixty", "seventy", "eighty", "ninety", "one hundred" };
           if(number>0&&number<=20)
            { NumberInString += List1[number]; }
           else if (number > 20 && number <= 100)
            {
                NumberInString += List2[number/10]+ " "+ConvertNumberToString(number%10);
            }else if (number > 100 && number <= 1000)
            {
                NumberInString += List1[number/100]+" hundred "+ConvertNumberToString(number%100);
            }
            else if (number > 1000 && number <= 20000)
            {
                NumberInString += List1[number / 1000] + " Thousand " + ConvertNumberToString(number % 1000);

            }else if (number > 20000 && number <= 100000)
            {
                NumberInString += List2[number / 10000]  + " "+ConvertNumberToString(number % 10000);
            }else if (number > 100000 && number <= 1000000)
            {
                NumberInString += List1[number / 100000] + " Hundred " + ConvertNumberToString(number % 100000);
            }
            return  NumberInString;
        }

        private void CtrlFindClient_Load(object sender, EventArgs e)
        {

        }
    }
}
