namespace Classes_Gun_5_Odev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Customer customer = new Customer();
            customer.City = "A";
            customer.Id = 1;
            customer.Name = "B";
            customer.Surname = "C";
            Customer customer2 = new Customer
            {
                Id = 2,
                Name = "Gencer",
                Surname = "Sevdin",
                City = "Ankara"
            };
            Console.WriteLine(customer2.Name);

        }
    }
}