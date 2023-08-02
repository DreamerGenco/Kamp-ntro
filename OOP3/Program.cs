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
<<<<<<< HEAD
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(tasitKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            basvuruManager.KrediOnbilgilendirmesiYap(krediler);


=======
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
>>>>>>> 4d9d74b9432094b8c9bc7afdae360738e2b4283c
            Console.ReadKey();
        }
    }
}
