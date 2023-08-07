using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Gun_5_Odev_1
{
    internal class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Name);
        }
    }
}
