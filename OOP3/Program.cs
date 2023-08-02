using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager konutKredi = new KonutKrediManager();
            IKrediManager tasitKredi = new TasitKrediManager();
            IKrediManager ihtiyacKredi = new IhtiyackrediManager();
            IKrediManager esnafKredi = new EsnafKrediManager();
            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKredi, new DataBaseLoggerService());   
            List<ILoggerService>loggers = new List<ILoggerService> { new SmsLoggerService(), new DataBaseLoggerService()};   

            List<IKrediManager> krediler = new List<IKrediManager>() {tasitKredi, esnafKredi};
            basvuruManager.BasvuruYap(esnafKredi, loggers);
            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            Console.ReadKey();
        }
    }
}
