namespace Generics
{
    internal class Program
    {
        static void Main(string[] args) 
        {         
            MyList<int> Files = new MyList<int>();
            Files.Add(35);
            Files.Add(35);
            Files.Add(35);
            Files.Add(35);
            Files.Add(35);
            Files.Add(35);
            Console.WriteLine(Files.Count);
        }
    }

    class MyList<T> //Generic class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
       public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;

        }
        private int _count;

        public int Count
        {
            get { return _array.Length; }
        }

    }
}