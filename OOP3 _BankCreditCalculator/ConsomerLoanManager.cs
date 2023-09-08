using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3__BankCreditCalculator
{
    internal class ConsomerLoanManager:ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Consomer loan has been calculated");
        }

    }
}
