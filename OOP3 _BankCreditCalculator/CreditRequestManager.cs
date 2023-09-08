using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3__BankCreditCalculator
{
    internal class CreditRequestManager
    {
        public void MakeApplication(ICreditManager creditManager)
        {
            creditManager.Calculate();
        }
        public void CreditPreliminaryInformation()
        {

        }
    }
}
