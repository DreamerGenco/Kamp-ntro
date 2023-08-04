using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Method injection
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediler, List<ILoggerService> loggerServices)
        {
            //Basvuran bilgilerini degerlendirme
            krediler.Hesapla();

            krediler.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void KrediOnbilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
                
            }


        }
    }
}

