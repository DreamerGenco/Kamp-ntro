using CustomerManagementSystem.Abstract;
using CustomerManagementSystem.Concrete;
using CustomerManagementSystem.Entities;

namespace CustomerManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbacksCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1989, 06, 26), FirstName = "Gencer", LastName = "SEVDİN", NationalityId = "33124998830" });
                
        }
       
    }
}