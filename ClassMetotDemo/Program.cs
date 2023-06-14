
using ClassMetotDemo;

Console.WriteLine("Hello, World!");
Musteri musteri = new Musteri();
musteri.ID = 1;
musteri.Name = "Gencer";
musteri.SurName = "Sevdin";
musteri.TcNo = "123456";
musteri.Description = "skdfskghkfjg";

Musteri musteri1 = new Musteri();
musteri1.ID = 2;
musteri1.Name = "Alper";
musteri1.SurName = "SEVDİN";
musteri1.TcNo = "656786786";
musteri1.Description = "nnvbnvbnvm";

Musteri[] musteriler = new Musteri[] {musteri, musteri1 };

foreach (var m in musteriler)
{
    Console.WriteLine("Musteri Adı: " + m.Name + ", " + "Musteri_Soyadi: "+  m.SurName + ", " + "Musteri_Tc_No: " + m.TcNo + ", " + "Aciklama: " + m.Description + ".");

}
MusteriManager musteriManager = new MusteriManager();
musteriManager.Add(musteri1);

Console.ReadKey();
