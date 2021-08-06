using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Gencer";
            int yas = 32;
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Gencer";
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Alper";
            kurs2.KursAdi = "Java";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Suat";
            kurs3.KursAdi = "Python";
            kurs3.IzlenmeOrani = 88;

            Kurs kurs4 = new Kurs();
            kurs4.Egitmen = "Meral";
            kurs4.KursAdi = "aaaa";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};   

            foreach  (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen + " : "
                    + " : " + kurs.IzlenmeOrani + 
                     " : " + kurs.KursAdi);
            }


        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
        
    }
}
