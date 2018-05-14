using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models.Facade
{
    public class AccountNumberCheck
    {
        private int accountNumber = 12345678;
        private int getAccountNumber() { return accountNumber; }

        public Boolean accountActive(int acctNumToCheck)
        {
            if (acctNumToCheck == getAccountNumber())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}