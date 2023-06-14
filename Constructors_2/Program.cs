namespace Constructors_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer () { Id = 1, FirstName = "Gencer", LastName = "Sevdin", City = "Ankara"};
            Customer customer2 = new Customer(2, "Alper", "SEVDİN", "Manisa");

            Console.WriteLine(customer2.FirstName);

        }
    }
    class Customer
    {
        public Customer()
        {
                
        }
        public Customer(int id, string firstName,string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;    
            City = city;


        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
