using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;


/*Задача 15: HashSet<T> — удаление дубликатов
Задача
Дан массив чисел.
Выведи только уникальные числа (в любом порядке), используя HashSet.
Пример входа: 1, 2, 2, 3, 1, 4, 5, 5
Ожидаемый вывод: 1 2 3 4 5 (или в другом порядке)*/
class Program
{
    static void Main()
    {
        HashSet<int> uniq = new HashSet<int>();
        Console.WriteLine("Введите числа через пробел: ");
        string input = Console.ReadLine()?.Trim() ?? string.Empty;

        string[] array = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string number in array)
        {
            if (int.TryParse(number, out int num))
            {
                uniq.Add(num);
            }
            else
            {
                Console.WriteLine("Неверное число!");
            }
        }

        Console.WriteLine(string.Join(", ", uniq));
    }
}
