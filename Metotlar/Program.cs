using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("----------------------");

            }

            Console.WriteLine("------Metotlar---------");
            //instance
            //encapsulation

            SepetManager SepetManager = new SepetManager();
            SepetManager.Ekle(urun1);
            SepetManager.Ekle(urun2);

            SepetManager.Ekle2("Armut", "Yeşil Armut", 12,4);
            SepetManager.Ekle2("Elma", "Yeşil Elma", 8,3);
            SepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 20,12);

        }
    }
}
