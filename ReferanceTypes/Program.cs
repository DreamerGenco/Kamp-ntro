
Person person1 = new Person();

Person person2 = new Person();

person1.FirstName = "Test";
person2 = person1;
person1.FirstName = "Derin";
Console.WriteLine(person2.FirstName);

Customer customer = new Customer();
customer.FirstName = "Test2";
customer.CreditCardNumber = "46546878";


Employee employee = new Employee();
employee.FirstName = "Veli";

Person person3 = customer;

customer.FirstName = "Test";
customer.LastName = "SurTestSur"; 
customer.CreditCardNumber = "97846546";
Console.WriteLine(customer.FirstName + customer.LastName + customer.CreditCardNumber);
Console.WriteLine(((Customer)person3).CreditCardNumber);
PersonManager personManager = new PersonManager();

personManager.Add(employee);

Console.ReadKey();

class Person    
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
class Customer:Person
{
    public string CreditCardNumber { get; set; }
}

class Employee:Person
{
    public int EmployeeNumber { get; set; }
}
class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
        
    }
}

