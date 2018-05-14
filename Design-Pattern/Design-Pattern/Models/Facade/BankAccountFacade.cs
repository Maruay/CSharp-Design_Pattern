using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models.Facade
{
    public class BankAccountFacade
    {
        private int accountNumber;
        private int securityCode;

        AccountNumberCheck acctChecker;
        SecurityCodeCheck codeChecker;
        FundsCheck fundChecker;

        public BankAccountFacade(int newAcctNum, int newSecCode) 
        {
            accountNumber = newAcctNum;
            securityCode = newSecCode;

            acctChecker = new AccountNumberCheck();
            codeChecker = new SecurityCodeCheck();
            fundChecker = new FundsCheck();
        }

        public int getAccountNumber() { return accountNumber; }
        public int getSecurityCode() { return securityCode; }

        public string withdrawCash(double cashToGet)
        {
            string ret = string.Empty;

            if (acctChecker.accountActive(getAccountNumber()) &&
                codeChecker.isCodeCorrect(getSecurityCode()) &&
                fundChecker.haveEnoughMoney(cashToGet))
            {
                ret = "Transaction Completed : Amount = " + fundChecker.getCashInAccount() + "\n";
            }
            else
            {
                ret = "Transaction Failed\n";
            }
            return ret;
        }

        public string depositCash(double cashToDeposit)
        {
            string ret = string.Empty;

            if (acctChecker.accountActive(getAccountNumber()) &&
                codeChecker.isCodeCorrect(getSecurityCode()))
            {
                fundChecker.makeDeposit(cashToDeposit);
                ret = "Transaction Completed : Amount = " + fundChecker.getCashInAccount() +  "\n ";
            }
            else
            {
                ret = "Transaction Failed\n";
            }
            return ret;
        }
    }
}