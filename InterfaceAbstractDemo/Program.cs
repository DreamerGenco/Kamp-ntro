using InterfaceAbstractDemo.Abstact;
using InterfaceAbstractDemo.Adapter;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager neroCustomer = new StarbucksCustomerManager(new MernisServiceAdapter());
           

            neroCustomer.Save(new Customer{ DateOfBirth = new DateTime(1989, 05, 26 ), FirstName = "Gencer", 
                LastName = "SEVDİN", NationalityId = "33124998831" });


        }
    }
}