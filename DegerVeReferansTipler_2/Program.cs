namespace DegerVeReferansTipler_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 1, 20, 30, 50 };
            //sayilar1= sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine("Sayilar1[0] = " + sayilar1[0] );
            Person person = new Person();
            Person person1 = new Person();
            person.FirstName = "Gencer";
            person1 = person;
            person.FirstName = "Derin";
            //Console.WriteLine(person1.FirstName);



            Customer customer = new Customer();
            customer.FirstName = "Alper";
            customer.CreditCardNumber =" 014802044205734";
            Employee employee = new Employee();
            employee.FirstName = "Ahmet";
            Person person3 = customer;


            //Console.WriteLine(((Customer)person3).CreditCardNumber );


            PersonManager personManager = new PersonManager();  
            personManager.Add(customer);
            personManager.Add(employee);
            personManager.Add(person3);


            Console.ReadKey();

        }
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
    }
}