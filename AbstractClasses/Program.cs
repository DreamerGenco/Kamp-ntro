namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MevzuatBase aMevzuat = new AMevzuat();
            aMevzuat.Degerlendir();
            aMevzuat.Kaydet();
            
        }
        abstract class MevzuatBase
        { 
            protected MevzuatBase()//Constructor of MevzuatBase Class
            {
            }
            public abstract void Degerlendir();
            public void Kaydet()
            {
                Console.WriteLine( "Kaydedildi");
            }

        }
        class AMevzuat : MevzuatBase
        {
            public override void Degerlendir()
            {
                Console.WriteLine( "A mevzuatına göre değerlendirildi");

            }
        }

               
            
            
    }
}