using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3__BankCreditCalculator
{
    internal class SmsLoggerService:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged as SMS");
        }
    }
}
