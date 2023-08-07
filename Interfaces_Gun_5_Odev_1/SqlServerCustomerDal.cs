using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Gun_5_Odev_1
{
    internal class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Server Add");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Server Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Server Updated ");
        }
    }
}
