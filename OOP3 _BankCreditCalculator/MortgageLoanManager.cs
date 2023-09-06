using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3__BankCreditCalculator
{
    internal class MortgageLoanManager:ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage loan has been calculated");
        }

    }
}
