using BankData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankBussiness
{
    public class ClsCurrencyBus
    {public enum enMode { AddNew=0,Update=1}
        public enMode mode=enMode.AddNew;
        public string CurrencyName { get; set; }
        public float CurrencyInDollar {  get; set; }
        public int CurrencyID { get; set; }
        public ClsCurrencyBus()
        {
            mode = enMode.AddNew;
            CurrencyID = 0;
            CurrencyName = "";
            CurrencyInDollar = 0;
        }
        private ClsCurrencyBus(int CurrencyID,string CurrencyName,float CurrencyInDollar)
        {mode = enMode.Update;
           this. CurrencyID = CurrencyID;
            this.CurrencyInDollar = CurrencyInDollar;
            this.CurrencyName = CurrencyName;
        }
        public static DataTable GetAllCurrencies()
        {
            return ClsCurrencyData.GetAllCurrencies();
        }
        public static ClsCurrencyBus GetCurrencyBy(int CurrencyID)
        {
            string CurrencyName = "";
            float CurrencyInDollar = 0;
            bool IsFound = ClsCurrencyData.GetCurrencyBy(CurrencyID,ref CurrencyName,ref CurrencyInDollar);
            if (IsFound) { return new ClsCurrencyBus(CurrencyID,CurrencyName,CurrencyInDollar); }
            return null;
        }        public static ClsCurrencyBus GetCurrencyBy(string CurrencyName)
        {
            int CurrencyID = 0;
            float CurrencyInDollar = 0;
            bool IsFound = ClsCurrencyData.GetCurrencyBy(ref CurrencyID, CurrencyName,ref CurrencyInDollar);
            if (IsFound) { return new ClsCurrencyBus(CurrencyID,CurrencyName,CurrencyInDollar); }
            return null;
        }
        public static bool DeleteCurrecny(int CurrencyID)
        {
            return ClsCurrencyData.DeleteCurrency(CurrencyID);
        }
        private bool _AddNewCurrency()
        {
            this.CurrencyID=ClsCurrencyData.AddNewCurrency(this.CurrencyName,this.CurrencyInDollar);
            return this.CurrencyID > 0;
        }
        private bool _UpdateCurrency()
        {
            return ClsCurrencyData.UpdateCurrency(this.CurrencyName,this.CurrencyInDollar,this.CurrencyID);
        }
        public bool Save()
        {
            switch (mode)
            {
                case enMode.AddNew:
                    if (_AddNewCurrency())
                    {
                        mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateCurrency();
            }
            return false;
        }
    }
}
