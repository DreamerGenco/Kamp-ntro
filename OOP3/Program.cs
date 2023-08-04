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
            IKrediManager ihtiyacKrediManager = new IhtiyackrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(tasitKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            basvuruManager.KrediOnbilgilendirmesiYap(krediler);


            IKrediManager konutKredi = new KonutKrediManager();
            IKrediManager tasitKredi = new TasitKrediManager();
            IKrediManager ihtiyacKredi = new IhtiyackrediManager();
            IKrediManager esnafKredi = new EsnafKrediManager();
            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            //basvuruManager.BasvuruYap(konutKredi, new DataBaseLoggerService());   
            List<ILoggerService>loggers = new List<ILoggerService> { new SmsLoggerService(), new DataBaseLoggerService()};   
            basvuruManager.BasvuruYap(esnafKredi, loggers);
            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            Console.ReadKey();
        }
    }
}
