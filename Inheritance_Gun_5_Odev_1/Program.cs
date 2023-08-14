namespace Inheritance_Gun_5_Odev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3] 
            { 
                new Customer{Firstname = "Gencer"},
                new Student{Firstname = "Alper"},
                new Person{Firstname = "Suat"}
            };
                foreach (Person person in persons) { Console.WriteLine(person.Firstname); }
                Console.ReadKey();
        }
        interface IPerson
        {

        }
        class Person
        {
            public int Id { get; set; }
            public string Firstname { get; set; }
            public string LastName { get; set; }
            
        }
        class Customer:Person
        {
            public string city { get; set; }
        }
        class Student : Person
        {
            public string Departmant { get; set; }
        }
    }
}