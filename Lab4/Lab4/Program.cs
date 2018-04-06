using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class HashTable
    {

        public class Pair
        {
            public object Key { get; set; }
            public object Value { get; set; }
        }

        List<List<Pair>> hashTable;

        public void CreateHashTable(int size)
        {
            hashTable = new List<List<Pair>>(size);
            for (int i = 0; i < size; i++)
            {
                hashTable.Add(new List<Pair>());
            }
        }

        public void PutPair(object key, object value)
        {
            var number = GetNumber(key);
            foreach (var e in hashTable[number])
            {
                if (Equals(e.Key, key))
                {
                    e.Value = value;
                    return;
                }
            }
            hashTable[number].Add(new Pair { Key = key, Value = value });
        }

        public int GetNumber(object key)
        {
            return Math.Abs(key.GetHashCode()) % hashTable.Count;
        }

        public object GetValueByKey(object key)
        {
            var number = GetNumber(key);
            foreach (var e in hashTable[number])
            {
                if (Equals(e.Key, key))
                {
                    return e.Value;
                }
            }
            return null;
        }

        public static void Main()
        {
        }
    }
}