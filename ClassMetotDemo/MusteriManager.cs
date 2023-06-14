using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi; " + musteri.Name);

        }
        public void Remove() 
        { 
            Console.WriteLine("Musteri Silindi");
        }
        public void List()
        {
            Console.WriteLine("Liste");
        }

        
    }
}
