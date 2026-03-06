using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Collections;


/*Задача 26:Split + Join + Replace
Введи строку (например: "hello   world!   test")
Убери все лишние пробелы, замени "!" на "?" и выведи слова через запятую.
Ожидаемый вывод: hello, world?, test*/
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

        string withQ = input.Replace("!", "?");
        string[] words = withQ.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string result = string.Join(", ", words);

        Console.WriteLine(result);
    }
}

