using BankData;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBussiness
{
    public class ClsUserBus:ClsPersonBus
    {
        public enum enMode { addNew = 0, update = 1 }
        public enMode mode = enMode.addNew;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public ClsUserBus()
        {
            mode = enMode.addNew;
            this.UserID = 0;
            this.PersonID = 0;
        }
        private ClsUserBus(int personID, int UserID)
        {
            mode = enMode.update;
            this.UserID = UserID;
            this.PersonID = personID;
        }
        public static DataTable GetAllUsers()
        {
            return ClsUserData.GetAllUsers();
        }
        public bool AddNewUser()
        {
            ClsUserBus user= new ClsUserBus();
            // this.Password = ClsUserBus.EncriptText(this.Password, 10);
            base.PersonID = ClsPersonData.AddNewPerson(this.Name, this.Password, this.AccountNumber, this.ImagePath, this.AccountBalance, this.CurrencyID, this.DateOfBirth);
            this.UserID = ClsUserData.AddNewUser(base.PersonID);
            return this.UserID > 0;

        }
        public bool Save()
        {
            switch (mode)
            {
                case enMode.addNew:
                    if (AddNewUser()) { mode = enMode.update; return true; }
                    else { return false; }
                case enMode.update:
                    return this.UpdatePerson();
            }
            return false;
        }

        public static bool DeleteUser(int PersonID)
        {
            if (ClsUserData.DeleteUser(PersonID))
            {
                if (ClsPersonBus.DeletePerson(PersonID))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

