using System;
using System.Collections.Generic;


namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Gencer", "Alper", "Meral", "Suat" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler.Add("Ilker");
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);
          



        }
    }
}
