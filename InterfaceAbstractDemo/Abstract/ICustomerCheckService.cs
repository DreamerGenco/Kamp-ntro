using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerCheckService
    {
        Task<bool> CheckIfRealPerson(Customer customer);
    }
}
