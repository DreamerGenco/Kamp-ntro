using System.Security.Cryptography;

namespace MyDictionary;

class Program
{
    static void Main(string[] args)
    {
        MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
        myDictionary.Add(1, "a");
        myDictionary.Add(2, "b");   
        myDictionary.Add(3, "c");
       myDictionary.PrintKeysAndValues();
        Console.WriteLine("Count: " + myDictionary.Count);

    }
}
