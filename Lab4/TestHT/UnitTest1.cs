using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab4;
using System.Collections.Generic;

namespace TestHashTable
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestThreeElements()
        {
            var hashTable = new HashTable();
            var list = new List<string>();
            hashTable.CreateHashTable(3);
            hashTable.PutPair(123, "элемент");
            hashTable.PutPair(789, 1234);
            hashTable.PutPair("key", 456);

            var keys = new object[] { 123, 789, "key" };
            var values = new object[] { "элемент", 1234, 456 };
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(hashTable.GetValueByKey(keys[i]), values[i]);
            }
        }

        [TestMethod]
        public void TestTwoEqualKeys()
        {
            var hashTable = new HashTable();
            hashTable.CreateHashTable(2);
            hashTable.PutPair(1, 123);
            hashTable.PutPair(1, 456);

            var key = 1;
            var value = 456;
            Assert.AreEqual(hashTable.GetValueByKey(key), value);
        }

        [TestMethod]
        public void TestOneFromTenThousand()
        {
            var hashTable = new HashTable();
            int size = 10000;
            hashTable.CreateHashTable(size);
            for (int i = 0; i < size; i++)
                hashTable.PutPair(i, i + 1);
            Assert.AreEqual(hashTable.GetValueByKey(3500), 3501);
        }

        [TestMethod]
        public void TestSearchingNotAddedKeys()
        {
            var hashTable = new HashTable();
            var size = 10000;
            hashTable.CreateHashTable(size);
            for (int i = 0; i < size; i++)
                hashTable.PutPair(i, i + 1);
            for (int i = size; i < size + 1000; i++)
                Assert.AreEqual(hashTable.GetValueByKey(i), null);
        }
    }
}
