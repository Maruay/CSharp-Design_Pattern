using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Design_Pattern.Models.Facade
{
    public class SecurityCodeCheck
    {
        private int securityCode = 1234;
        public int getSecurityCode() { return securityCode; }

        public Boolean isCodeCorrect(int secCodeToCheck)
        {
            if (securityCode == getSecurityCode())
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