using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine()?.Trim() ?? "";

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Ничего не введено");
            return;
        }

        var countWords = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                              .Select(x => x.ToLower())
                              .GroupBy(x => x)
                              .Select(g => new { Word = g.Key, Count = g.Count() })
                              .OrderByDescending(x => x.Count);

        Console.WriteLine("Частота слов:");
        foreach (var item in countWords)
        {
            Console.WriteLine($"{item.Word}: {item.Count}");
        }
    }
}
