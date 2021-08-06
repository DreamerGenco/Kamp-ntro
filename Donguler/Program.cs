using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string kurs1 = "Yazılım geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";*/

            //array - dizi

            string[] kurslar = new string[] { "Yazılım geliştirici Yetiştirme Kampı", 
                                              "Programlamaya başlangıç için temel kurs",
                                               "Java", "Python","C++", "C#"};
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu- footer");

            int j = 0;
            while ( j < kurslar.Length)
            {
                Console.WriteLine(kurslar[j]);
                j++;
            }
        }
    }
}
