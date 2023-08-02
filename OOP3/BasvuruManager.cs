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
        public void BasvuruYap(IKrediManager krediler, List<ILoggerService>loggerServices)
        {
<<<<<<< HEAD
            //Basvuran bilgilerini degerlendirme
            krediManager.Hesapla();
=======
           
            krediler.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            };
>>>>>>> 4d9d74b9432094b8c9bc7afdae360738e2b4283c
        }
        public void KrediOnbilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
<<<<<<< HEAD

            }

=======
            }
>>>>>>> 4d9d74b9432094b8c9bc7afdae360738e2b4283c
        }
    }
}
