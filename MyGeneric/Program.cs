namespace MyGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileTypes<string> fileTypes = new FileTypes<string>();
            fileTypes.Add("Hukuk");
            fileTypes.Add("KYOK");
            fileTypes.Add("İdari Dosyalar");
            Console.WriteLine(fileTypes.Count);
        }

    }
    class FileTypes<T>
    {
        T[] _array;
        T[] _tempArray;
        public FileTypes() 
        {
            _array = new T[0];

        }
        public void Add(T fileTypes)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];

            }
            _array[_array.Length - 1] = fileTypes;
        }

        private int count;

        public int Count
        {
            get { return _array.Length; }
            }
        }



    }
