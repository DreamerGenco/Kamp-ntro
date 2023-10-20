using CustomerManagementSystem.Abstract;
using CustomerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.Concrete
{
    internal class CustomerCheckManager:ICustomerCheckService
    {
       public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        } 
    }
}   
