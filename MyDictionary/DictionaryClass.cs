using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class DictionaryClass<T,Z>
    {
        T[] keys;
        Z[] values;
        T[] tempKey;
        Z[]tempValues;
        

        public DictionaryClass()
        {
            keys = new T[0];
            values = new Z[0];  
        }
        public void Add(T key, Z value)
        {
           tempKey = keys;
           tempValues = values;
            keys = new T[keys.Length + 1];
            values = new Z[keys.Length + 1];   
           for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }
            for (int j = 1; j < tempValues.Length; j++)
            {
                values[j] = tempValues[j];
            }
            keys[keys.Length-1] = key;
            values[keys.Length-1] = value;
        }
        public int KeyLength
        {
            get { return keys.Length; }
          
        }
        public int ValuesLength
        {
              get { return values.Length; }
        }

    }
}
