using MyDictionary;

DictionaryClass<int, string> numbers = new DictionaryClass<int, string>();
numbers.Add(1, "One");
Console.WriteLine(numbers.KeyLength);
Console.WriteLine(numbers.ValuesLength);
numbers.Add(2, "Two");
Console.WriteLine(numbers.KeyLength);
Console.WriteLine(numbers.ValuesLength);
numbers.Add(3, "Three");
Console.WriteLine(numbers.KeyLength);
Console.WriteLine(numbers.ValuesLength);