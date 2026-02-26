using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Collections;


/*Задача 20:FirstOrDefault + Skip/Take
Дан List<int> numbers = { 10, 20, 30, 40, 50, 60 };
Выведи:

Первый элемент > 25
Элементы с 3-го по 5-й (индексы 2–4)

Ожидаемый вывод:
Первый > 25: 30
С 3-го по 5-й: 30, 40, 50*/
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50, 60 };

        var first25 = numbers.Where(x => x > 25).FirstOrDefault();
        var index35 = numbers.Skip(2).Take(3).ToList();

        
        Console.WriteLine($"Первый > 25: {first25}");
        Console.Write($"С 3-го по 5-й: ");
        foreach (var item in index35)
        {
            Console.Write(item + ", ");
        }
        
    }
}
