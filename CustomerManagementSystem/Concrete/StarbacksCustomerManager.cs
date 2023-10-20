using CustomerManagementSystem.Abstract;
using CustomerManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.Concrete
{
    public class StarbacksCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;
        public StarbacksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }   

        public override void Save(Customer customer)
        {
            if(_customerCheckService.CheckIfRealPerson(customer)) 
            { 
                base.Save(customer); 
             }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
