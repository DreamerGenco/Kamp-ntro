namespace Interfaces_Gun_5_Odev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          IPersonManager customerManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();
           
          ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Add(employeeManager);
            projectManager.Add(new InternManager());

     


        }
    }
}