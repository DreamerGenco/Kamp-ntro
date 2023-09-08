using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Gun_5_Odev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(2);
            Person[] persons = new Person[] { new Customer(), new student() };
        }
    }
}
