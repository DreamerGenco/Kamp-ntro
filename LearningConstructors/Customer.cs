using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningConstructors
{
    internal class Customer
    {
        //default constructor
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı");
        }
        public int ID { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
