using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace pos
{
    internal class Transaction
    {
        public int TransactionID;
        public string ProductName;
        public float Amount;
        public string time;
        public string date;
        public Transaction()
        {

        }
        public Transaction(Transaction tr)
        {
            TransactionID = tr.TransactionID;
            ProductName = tr.ProductName;
            Amount = tr.Amount;
            time = tr.time;
            date = tr.date;
        }

    }
}
