using CustomerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.Abstract
{
    public interface ICustomerService
    {
        public void Save(Customer customer);
    }
}
