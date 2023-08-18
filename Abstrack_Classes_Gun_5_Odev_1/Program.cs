namespace Abstrack_Classes_Gun_5_Odev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amevzauat amevzauat = new Amevzauat();
            amevzauat.Kaydet();
            amevzauat.Degerlendir();
                
        }

        abstract class MevzuatBase
        {
            protected MevzuatBase()
            { 
            }
            public abstract void Degerlendir();
            public void Kaydet()
            {
                Console.WriteLine("Kaydedildi");
            }
        }
        class Amevzauat:MevzuatBase
        {
            public override void Degerlendir() { Console.WriteLine("A mevzuatına göre değerlendirildi"); }

        }
        class CustomerManager
        {
            public void Add()
            {
                Console.WriteLine("Added");
            }
            public void Delete()
            {
                Console.WriteLine("Deleted");
            }
            class Customer
            {
                public int Id { get; set; }
                public string Name { get; set; }

            }

        }
    }
}