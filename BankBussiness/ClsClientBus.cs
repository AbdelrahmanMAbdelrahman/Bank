using BankData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBussiness
{
    public class ClsClientBus:ClsPersonBus
    {public enum enMode { addNew=0,update=1 }
        public enMode mode = enMode.addNew;
        public int ClientID {  get; set; }
        public int PersonID {  get; set; }
     
        public ClsClientBus()
        {
            mode = enMode.addNew;
            this.ClientID = 0;
           this. PersonID = 0;
        }
        private ClsClientBus(int personID,int ClientID)
        {mode = enMode.update;
            this.ClientID = ClientID;
            this.PersonID = personID;
}
        public static DataTable GetAllClients()
        {
            return ClsClientData.GetAllClients();
        }
        public   bool AddNewClient()
        {ClsClientBus client=   new ClsClientBus();
           // this.Password = ClsClientBus.EncriptText(this.Password, 10);
            base.PersonID = ClsPersonData.AddNewPerson(this.Name, this.Password, this.AccountNumber, this.ImagePath, this.AccountBalance, this.CurrencyID, this.DateOfBirth);
            this.ClientID = ClsClientData.AddNewClient(base.PersonID);
            return this.ClientID > 0;

        }
     public bool Save()
        {
            switch (mode)
            {case enMode.addNew: if (AddNewClient()) { mode = enMode.update;return true;}
                    else { return false;}
                case enMode.update:
                    return this.UpdatePerson();
            }return false;
        }

        public static  bool DeleteClient(int PersonID)
        {
            if (ClsClientData.DeleteClient(PersonID)){
                if (ClsPersonBus.DeletePerson(PersonID)) { 
                return true;
                }
            }
            return false;
        }
    }
}
