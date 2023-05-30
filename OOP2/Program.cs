using OOP2;

RealPerson customer1 = new RealPerson();
customer1.CustomerNumber = "12345";
customer1.CustomerName = "Gencer";
customer1.CustomerSurname = "Sevdin";
customer1.TcNo = "1231324234";

BodyCorporate corporate = new BodyCorporate();
corporate.CustomerNumber = "54321";
corporate.Id = 2;
corporate.CompanyName = "Kodlama.io";
corporate.TaxId = "343445645";

//Gerçek Müşteri - Tüzel Müşteri
//SOLID

Customers customer3 = new RealPerson();
Customers customer4 = new BodyCorporate();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer4);
customerManager.Add(customer3);
customerManager.Add(corporate);
