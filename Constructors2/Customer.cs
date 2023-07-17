using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors2
{
    internal class Customer
    {
        public Customer()
        {

        }

        //default Constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = Id;
            FirstName = firstName;
            LastName = lastName;
            City = City;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
