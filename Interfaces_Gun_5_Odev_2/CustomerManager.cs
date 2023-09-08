using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Gun_5_Odev_2
{
    internal class CustomerManager:IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri eklendi");
        }
        public void Update() 
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }
}
