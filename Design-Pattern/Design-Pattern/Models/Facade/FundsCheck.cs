using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models.Facade
{
    public class FundsCheck
    {
        private double cashInAccount = 1000.00;

        public double getCashInAccount() { return cashInAccount; }

        public void decreseCashInAccount(double cashWithdrawn)
        {
            cashInAccount -= cashWithdrawn;
        }

        public void increseCashInAccount(double cashDeposited)
        {
            cashInAccount += cashDeposited;
        }

        public Boolean haveEnoughMoney(double cashToWithdrawal)
        {
            if (cashToWithdrawal > getCashInAccount())
            {
                return false;
            }
            else
            {
                decreseCashInAccount(cashToWithdrawal);
                return true;
            }
        }

        public void makeDeposit(double cashToDeposit)
        {
            increseCashInAccount(cashToDeposit);
        }
    }
}