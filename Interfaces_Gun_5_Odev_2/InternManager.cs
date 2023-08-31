using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Gun_5_Odev_2
{
    internal class InternManager:IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajer eklendi");
        }
        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }
}
