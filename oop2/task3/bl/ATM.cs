using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.bl
{
    internal class ATM
    {
        public int amount = 70000;
        List<ATM> transList=new List<ATM>();

        public int dipositMoney(int depositAmount)
        {
            amount = depositAmount + amount;
            return amount;
        }
        public int withdrawMoney(int withdrawAmount)
        {
            amount=amount - withdrawAmount;
            return amount;
        }
        public int checkBalance()
        {
            return amount;
        }


    }
   
}
