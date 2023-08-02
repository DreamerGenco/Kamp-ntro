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
            
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKredi);
            List<IKrediManager> krediler = new List<IKrediManager>() {tasitKredi};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            Console.ReadKey();
        }
    }
}
