using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication
{
    class Program
    {
        public static int BinarySearch(int[] array, int value)
        {
            //код поиска значения value в массиве array

            if (array.Length == 0)
            {
                return -1;
            }
            var left = 0;
            var right = array.Length - 1;
            while (left < right)
            {
                var middle = (right + left) / 2;
                if (value <= array[middle])
                    right = middle;
                else left = middle + 1;
            }
            if (array[right] == value)
                return right;
            return -1;
        }


        static void Main(string[] args)
        {
            TestSimpleArray();
            TestNegativeNumbers();
            TestNonExistentElement();
            TestRepeatingElement();
            TestEmptyArray();
            TestBigArray();
            Console.ReadKey();

        }
        private static void TestSimpleArray()
        {
            //Тестирование поиска элемента в массиве из 5 элементов
            int[] simpleArray = new[] { 1, 2, 3, 4, 5 };
            if (BinarySearch(simpleArray, 4) != 3)
                Console.WriteLine("! Поиск не нашёл число 4 среди чисел  {1, 2, 3, 4, 5 }");
            else
                Console.WriteLine("Поиск среди 5 элементов работает корректно");
        }

        private static void TestNegativeNumbers()
        {
            //Тестирование поиска в отрицательных числах

            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -3) != 2)
                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");
        }

        private static void TestNonExistentElement()
        {
            //Тестирование поиска отсутствующего элемента

            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -1) >= 0)
                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат работает корректно");
        }

        private static void TestRepeatingElement()
        {
            //Тестирование поиска повторяющегося элемента

            int[] repeatingElement = new[] { 1, 2, 2, 2, 3 };
            if (BinarySearch(repeatingElement, 2) != 1)
                Console.WriteLine("! Поиск неправильно определил индекс числа 2 среди чисел {1, 2, 2, 2, 3}");
            else
                Console.WriteLine("Поиск повторяющегося элемента работает корректно");
        }
        private static void TestEmptyArray()
        {
            //Тестирование поиска в пустом массиве

            int[] emptyArray = new int[0];
            if (BinarySearch(emptyArray, 2) != -1)
                Console.WriteLine("! Поиск нашел индекс в пустом массиве");
            else
                Console.WriteLine("Поиск в пустом массиве работает корректно");
        }
        private static void TestBigArray()
        {
            //Тестирование массива из 100001 элементов

            int[] bigArray = new int[100001];
            for (var i = 0; i < 100001; i++)
            {
                bigArray[i] = i;
            }
            if (BinarySearch(bigArray, 1000) != 1000)
                Console.WriteLine("! Поиск неправильно нашел индекс в большом массиве");
            else
                Console.WriteLine("Поиск в большом массиве работает корректно");
        }
    }
}