using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Library;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SortSimpleArray()
        {

            Random random = new Random();
            var array = new int[3];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next();
            Solve.QuickSort(array);

            Assert.IsTrue(array[0] <= array[1]);
            Assert.IsTrue(array[1] <= array[2]);
        }

        [TestMethod]
        public void SortEqualElements()
        {


            var array = new int[100];
            for (int i = 0; i < array.Length; i++)
                array[i] = 1;
            Solve.QuickSort(array);
            for (var j = 1; j < 100; j++)
                Assert.IsTrue(array[j - 1] == array[j]);
        }

        [TestMethod]
        public void SortRandom1000()
        {

            Random random = new Random();
            var array = new int[1000];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next();
            Solve.QuickSort(array);
            for (var j = 0; j < 10; j++)
            {
                Assert.IsTrue(array[j] <= array[j + 10]);
            }
        }

        [TestMethod]
        public void SortEmptyArray()
        {
            var array = new int[0];
            Solve.QuickSort(array);
            Assert.AreEqual(array.Length, 0);
        }

        [TestMethod]
        public void SortRandom150000000()
        {

            Random random = new Random();
            var array = new int[150000000];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next();
            Solve.QuickSort(array);
            for (var j = 0; j < 10; j++)
            {
                Assert.IsTrue(array[j] <= array[j + 100]);
            }
        }

    }
}
