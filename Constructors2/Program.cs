using Constructors2;

Customer customer1 = new Customer { Id = 1, FirstName = " Gencer", LastName = "SEVDİN", City = "Ankara"};

Customer customer3 = new Customer();

customer3.Id = 3;


Customer customer2 = new Customer(2, "Alper", "SEVDİN", "ANKARA");

Console.WriteLine(customer2.FirstName);