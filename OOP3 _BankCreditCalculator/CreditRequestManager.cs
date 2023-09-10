using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3__BankCreditCalculator
{
    internal class CreditRequestManager
    {
        //Method injection
       
        public void MakeApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
           foreach (ILoggerService loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void CreditPreliminaryInformation(List<ICreditManager> krediler)
        {
            foreach (var credit in krediler) 
            {
                credit.Calculate();
            }
        }
    }
}
