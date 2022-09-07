using Constructors;

Customer customer = new Customer { ID = 1, FirstName ="Gencer", LastName = "SEVDİN", City = "İzmir"};

Customer customer2 = new Customer (2, "Alper", "SEVDİN", "ANKARA");

Console.WriteLine(customer2.City);