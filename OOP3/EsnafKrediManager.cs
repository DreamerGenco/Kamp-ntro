using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class EsnafKrediManager : IKrediManager
    {
        void IKrediManager.Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi ödeme planı hesaplandı.");
        }
    }
}
