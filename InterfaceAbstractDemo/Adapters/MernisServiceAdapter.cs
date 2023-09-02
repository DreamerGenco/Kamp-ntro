using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer) 
        {
             
        }
    }
}
