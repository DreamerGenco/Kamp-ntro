using ClassMetotDemo;

Console.WriteLine("Hello, World!");
Musteri musteri = new Musteri();
Musteri musteri1 = new Musteri();
Musteri musteri2 = new Musteri();

musteri.Id = 1;
musteri.Name = "Alper";
musteri.Surname = "SEVDIN";
musteri.Phone = 45345356;
musteri2.Id = 2;
musteri2.Name = "Suat";
musteri2.Surname = "SEVDIN";
musteri2.Phone = 0890009090;
musteri1.Id = 0;
musteri1.Name = "Gencer";
musteri1.Surname = "SEVDIN";
musteri1.Phone = 1231352345;

Musteri[] musteriler = new Musteri[]{ musteri, musteri1, musteri2 };

MusteriManager musteriManager = new MusteriManager();
musteriManager.List(musteriler);


