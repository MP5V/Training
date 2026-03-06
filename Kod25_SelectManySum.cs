using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            var groups = new List<List<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 4, 5 },
                new List<int> { 6, 7, 8, 9 }
            };

            var totalSum = groups.SelectMany(x => x).Sum();

            Console.WriteLine($"Сумма всех чисел: {totalSum}");
        }
    }
}
