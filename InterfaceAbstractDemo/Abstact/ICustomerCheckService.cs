﻿using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstact
{
    public interface ICustomerCheckService
    {
         bool CheckIfRealPerson(Customer customer);
    }
}
