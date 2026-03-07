using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;


/*Задача 29:Regex (простой)
Введи строку.
Проверь, состоит ли она только из цифр (используй Regex.IsMatch).
Если да — выведи "Только цифры", иначе "Есть другие символы".*/
class Program
{
    static void Main()
    {
        string onlyMath = Console.ReadLine();

        if (Regex.IsMatch(onlyMath, @"^\d+$"))
        {
            Console.WriteLine("Только цифры");
        } else Console.WriteLine("Есть другие символы");
    }
}

