using BankData;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BankBussiness
{
    public class ClsPersonBus
    {
        public enum enMode { addNew=0,update=1}
        public enMode Mode=enMode.addNew;
        public string AccountNumber { get; set;}
        public string Password {  get; set;}
       
        public string Name {  get; set;}
        public int PersonID {  get; set;}
        public int CurrencyID { get; set; }
        public DateTime DateOfBirth {get; set;}public float AccountBlance {  get; set; }
        //public byte IsUser {  get; set; }
        public string ImagePath {  get; set;}
        public float AccountBalance {  get; set; }
       
        public ClsPersonBus()
        {
            this.ImagePath = "";
            this.PersonID = 0;
            this.CurrencyID = 0;
            this.AccountBalance = 0;
            this.AccountNumber = "";
            this.Password = "";
            this.DateOfBirth = DateTime.Now;
            this.Name = "";
         //  this.IsUser = 0;
            Mode = enMode.addNew;
        }
        private ClsPersonBus(int PersonID,int CurrencyID,float AccountBalance,string ImagePath,
            string Password,string AccountNumber,string Name,DateTime DateOfBirth)
        {
            Mode = enMode.update;
            this.ImagePath=ImagePath;
            this.CurrencyID=CurrencyID;
            this.AccountBalance=AccountBalance;
            this.AccountNumber=AccountNumber;
            this.Password="";
            this.Name=Name;
            this.DateOfBirth=DateOfBirth;
            //this.IsUser = IsUser;
            this.PersonID=PersonID;
        }
        private static char EncriptChar(char ch, int key)
        {
            ch = ((char)((int)ch + (key)));
            return ch;
        }
        public static bool HandlePersonImage(ref string ImagePath)
        {//ClsPersonBus person=ClsPersonBus.GetPersonBy(personID);
            if (ImagePath != "")
            {
                //if (PictureImage != ImagePath) {
                //    File.Delete(ImagePath);
                //}
                string DestinationFolder = @"C:\Bank\";
                if (!CreateDirectoryIfNotExists(DestinationFolder))
                {
                    return false;
                }
                string DestinationImageFile = DestinationFolder + ReplaceFileNameWithGuid(ImagePath);
              File.Copy(ImagePath, DestinationImageFile, true);
                ImagePath = DestinationImageFile;
                return true;
            }return false;

        }

        private static string ReplaceFileNameWithGuid(string imagePath)
        {
           FileInfo fileInfo = new FileInfo(imagePath);
            string Extn=fileInfo.Extension;
            Guid guid = Guid.NewGuid();
            return guid.ToString() + Extn ;
        }

        private static bool CreateDirectoryIfNotExists(string destinationFolder)
        {
            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
                return true;
            }return true;
        }

        public static string EncriptText(string Text)
        {

            //char[] TextArray = Text.ToCharArray();
            //for (int i = 0; i < Text.Length; i++)
            //{
            //    TextArray[i] = EncriptChar(TextArray[i], key);
            //}
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(Text));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }

        }
        //private static char DecriptChar(char ch, int key)
        //{
        //    ch = (char)((int)ch - (key));
        //    return ch;
        //}
        //public static string DecriptText(string Text, int key)
        //{

        //    char[] TextArray = Text.ToCharArray();
        //    for (int i = 0; i < Text.Length; i++)
        //    {
        //        TextArray[i] = DecriptChar(TextArray[i], key);
        //    }
        //    return new string(TextArray);
        //}
        public static DataTable GetAllPeople()
        {
            return ClsPersonData.GetAllPeople();
        }
        public static bool DeletePerson(int PersonID)
        {
            return ClsPersonData.DeletePerson(PersonID);
                 
        }

     private bool AddNewPerson()
        {
           // this.Password = EncriptText(this.Password,10);
            this.PersonID = ClsPersonData.AddNewPerson(this.Name,this.Password,this.AccountNumber,
                this.ImagePath,this.AccountBlance,this.CurrencyID,this.DateOfBirth);
            return this.PersonID > 0;
        }
        public bool UpdatePerson()
        {
            //this.Password=EncriptText(this.Password,10);
            return ClsPersonData.UpdatePerson(this.PersonID, this.Name, this.Password, this.AccountNumber,
                this.ImagePath, this.AccountBalance, this.CurrencyID, this.DateOfBirth);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.addNew:
                    if (AddNewPerson())
                    {
                        Mode=enMode.update;
                        return true;
                    }
                    else { return false;}
                    case enMode.update:return UpdatePerson();
            }return false;
        }
        public static ClsPersonBus GetPersonBy(int PersonID)
        { string Name = "";
            string Password = "??";
            string AccountNumber = "";
            string ImagePath = "";
            float AccountBalance = 0;
         //   byte IsUser = 0;
            int CurrencyID = 0;
            DateTime DateOfBirth = DateTime.Now;
                 
            if(ClsPersonData.GetPersonBy(PersonID,ref Name,ref Password,ref AccountNumber,ref ImagePath,
                ref AccountBalance,ref CurrencyID,ref DateOfBirth))
            {
             //  Password = DecriptText(Password, 10);
                return new ClsPersonBus(PersonID,CurrencyID,AccountBalance,ImagePath,Password,AccountNumber,Name ,DateOfBirth);
            }
            else { return null; }
        }

        public static ClsPersonBus GetClientBy(int PersonID)
        {
            string Name = "";
            string Password = "";
            string AccountNumber = "";
            string ImagePath = "";
            float AccountBalance = 0;
            //   byte IsUser = 0;
            int CurrencyID = 0;
            DateTime DateOfBirth = DateTime.Now;

            if (ClsPersonData.GetClientBy(PersonID, ref Name, ref Password, ref AccountNumber, ref ImagePath,
                ref AccountBalance, ref CurrencyID, ref DateOfBirth))
            {
                //  Password = DecriptText(Password, 10);
                return new ClsPersonBus(PersonID, CurrencyID, AccountBalance, ImagePath, Password, AccountNumber, Name, DateOfBirth);
            }
            else { return null; }
        }
  
        public static bool DepositeAndWithdraw(int FromPersonID,
           int ToPersonID, decimal Amount, DateTime TransferDate, int TransferByUserID)
        {
            return ClsPersonData.DepositeAndWithdraw(FromPersonID,ToPersonID,Amount,TransferDate,TransferByUserID);
        }
        
        
        public static ClsPersonBus GetPersonBy(string AccountNumber)
        { string Name = "";
            string Password = "";
            int PersonID = 0;
            string ImagePath = "";
            float AccountBalance = 0;
          //  byte IsUser = 0;
            int CurrencyID = 0;
            DateTime DateOfBirth = DateTime.Now;
                 
            if(ClsPersonData.GetPersonBy(ref PersonID,ref Name,ref Password, AccountNumber,ref ImagePath,
                ref AccountBalance,ref CurrencyID,ref DateOfBirth))
            {
             //   Password = DecriptText(Password, 10);
                return new ClsPersonBus(PersonID,CurrencyID,AccountBalance,ImagePath,Password,AccountNumber,Name ,DateOfBirth);
            }
            else { return null; }
        }  
        
        
        public static ClsPersonBus GetPersonBy(string Name,string Password)
        {
            int PersonID = 0;
            
            string AccountNumber = "";
            string ImagePath = "";
            float AccountBalance = 0;
           // byte IsUser = 0;
            int CurrencyID = 0;
            DateTime DateOfBirth = DateTime.Now;
        //   Password = EncriptText(Password, 10);
            if (ClsPersonData.GetPersonBy(ref PersonID, Name,  Password,ref AccountNumber,ref ImagePath,
                ref AccountBalance,ref CurrencyID,ref DateOfBirth))
            {
                Password = Password;
                return new ClsPersonBus(PersonID,CurrencyID,AccountBalance,ImagePath,Password,AccountNumber,Name ,DateOfBirth);
            }
            else { return null; }
        }
        public static ClsPersonBus GetUserBy(string Name, string Password)
        {
            int PersonID = 0;

            string AccountNumber = "";
            string ImagePath = "";
            float AccountBalance = 0;
            // byte IsUser = 0;
            int CurrencyID = 0;
            DateTime DateOfBirth = DateTime.Now;
            //   Password = EncriptText(Password, 10);
            if (ClsPersonData.GetUserBy(ref PersonID, Name, Password, ref AccountNumber, ref ImagePath,
                ref AccountBalance, ref CurrencyID, ref DateOfBirth))
            {
                Password = Password;
                return new ClsPersonBus(PersonID, CurrencyID, AccountBalance, ImagePath, Password, AccountNumber, Name, DateOfBirth);
            }
            else { return null; }
        }
    }
}


