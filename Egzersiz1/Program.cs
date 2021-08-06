using System;

namespace Egzersiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int yolcu = 0;
            int soforDugme = 0;


            OtobusYolcuSistemi sistem1 = new OtobusYolcuSistemi();
               
           
            sistem1.YolcuDugme = 1;
            sistem1.SoforDugme = 0;
            sistem1.Lamba = 1;

            OtobusYolcuSistemi sistem2 = new OtobusYolcuSistemi();
            sistem2.Lamba = 0;
            sistem2.SoforDugme = 0;
            sistem2.YolcuDugme = 0;
            OtobusYolcuSistemi sistem3 = new OtobusYolcuSistemi();
            sistem3.YolcuDugme = 1;
            sistem3.SoforDugme = 1;
            sistem3.Lamba = 0;
            
            OtobusYolcuSistemi[] secenekler = new OtobusYolcuSistemi[] {sistem1,
            sistem2};
          
            if (yolcu == 1)
            {
                if (soforDugme == 0)
                {
                    Console.WriteLine("Duracak");

                }
            }
            if (yolcu == 0)
            {
                Console.WriteLine("Durmayacak");
            }
            
        }
    }
    class OtobusYolcuSistemi
    {
        public int Lamba { get; set; }

        public int YolcuDugme { get; set; }

        public int SoforDugme { get; set; }
    }
}
