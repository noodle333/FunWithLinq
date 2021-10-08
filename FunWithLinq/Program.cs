using System;
using System.Collections.Generic;
using System.Linq;

namespace FunWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>() { 1, 5, 7, 1, 13, 4, 346, 23, 7432, 2, 34, 14, 86, 25, 53, 83, 47, 2657, 264647, 375757, 36261, 1233 };

            Console.WriteLine("Unsorted.");
            foreach (int num in numList)
            {
                Console.Write(num + " ");
            }

            var sortEvenNum = numList.Where(x => x % 2 == 0).OrderBy(y => y).ToList();

            Console.WriteLine();

            Console.WriteLine("Sorted.");
            foreach (int num in sortEvenNum)
            {
                Console.Write(num + " ");
            }

            var sortOddNum = numList.Where(x => x % 2 == 1).OrderBy(y => y).ToList();
            foreach (int num in sortOddNum)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }
    }
}
