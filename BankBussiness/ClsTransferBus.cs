using BankData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankBussiness
{
    public class ClsTransferBus
    {public int ClientFromID {  get; set; }
        public int ClientToID { get; set; }
        public int TransferID {  get; set; }
        public DateTime TransferDate { get; set; }
        public int TransferByUserID {  get; set; }
        public float AmountInDollar {  get; set; }
        public enum enMode { addNew=0,update=1 }
        public enMode mode= enMode.addNew;
        public ClsTransferBus()
        {
            ClientFromID
                = 0;
            ClientToID = 0;
            TransferID = 0;
            TransferByUserID = 0;
            AmountInDollar = 0;
            TransferDate= DateTime.Now;
            mode = enMode.addNew;
        }
      public bool AddNewTransfer()
        {
            this.TransferID=ClstransferData.AddNewTransfer(this.ClientFromID,this.ClientToID,this.AmountInDollar,this.TransferByUserID,this.TransferDate);
            return this.TransferID>0;
        }
        public static bool DeleteTransfer(int ClientFromID)
        {
            return ClstransferData.DeleteTransfer(ClientFromID);
        }
        public static DataTable GetAllTransfers()
        {
            return ClstransferData.GetAllTransfers();
        }
    }
}
