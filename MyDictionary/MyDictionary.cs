using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<TKey, TValue>
    {
        
       TKey[] keys;
        TValue[] values;
        TKey[] tempKeys;
        TValue[] tempValues;
        public MyDictionary()
        {
            values = new TValue[0];
            keys = new TKey[0];
        }
        public void Add( TKey key, TValue value) 
        {
            tempKeys = keys;
            tempValues = values;

            values = new TValue[tempValues.Length + 1];
            keys = new TKey[tempKeys.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
                

            }         
            values[values.Length - 1] = value;
            keys[keys.Length - 1] = key;
            
            
        }
        public void PrintKeysAndValues()
        {
            for (int i = 0;i < keys.Length; i++)
            {
                Console.WriteLine("Key: " + keys[i] + ", Value: " + values[i]);
            }
        }

        
        public int Count
        {
            get { return keys.Length; }

        }
        public TKey[] Keys => keys;

        public TValue[] Values => values;

    }
   
}
