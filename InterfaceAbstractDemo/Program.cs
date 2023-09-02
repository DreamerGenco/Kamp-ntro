using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager= new NeroCustomerManager();
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1989, 05, 26),
                FirstName = "Gencer",
                LastName = "SEVDIN",
                NationalityId = "249928830"
            });
        }
    }
}