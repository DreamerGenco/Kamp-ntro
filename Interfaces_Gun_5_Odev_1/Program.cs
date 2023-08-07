using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Gun_5_Odev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Student { Id = 1, Name = "Gencer", LastName = "SEVDİN", Departmant = "Bilgisayar Mühendisliği" });

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
            Console.ReadKey(); 
        }
    }
}
