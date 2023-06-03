using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {

        public void Add()
        {
            Console.WriteLine("Musteri Eklendi");
        }
        public void Remove()
        {
            Console.WriteLine("Musteri has been removed");
        }
        public void List(Musteri[] musteriler)
        {
            foreach (Musteri m in musteriler)
            {
                Console.WriteLine("Musteri ID: " + m.Id);
                Console.WriteLine("Musteri Adi: " + m.Name);
                Console.WriteLine("Musteri Soyadi " + m.Surname);
                Console.WriteLine("Tel No: " + m.Phone);
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}
