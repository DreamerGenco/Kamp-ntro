using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Gun_5_Odev_2
{
    internal class EmployeeManager:IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Çalışan eklendi");
        }
        public void Update()
        {
            Console.WriteLine("Çalışan güncellendi");
        }
    }
}
