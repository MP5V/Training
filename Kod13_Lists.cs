using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Linq;
using System.Collections.Generic;


/*Задача 13: List<T> -- динамический массив
Задача
Дан массив чисел (входные данные).
Создай List<int>, удали из него все отрицательные числа, отсортируй по возрастанию и выведи результат.
Пример входа: 5, -3, 8, -1, 0, 4
Ожидаемый вывод: 0 4 5 8*/
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите числа через пробел: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<int> numbers = new List<int>();

        foreach (string part in parts)
        {
            if (int.TryParse(part, out int num))
            {
                numbers.Add(num);
            }
            else
            {
                Console.WriteLine($"Неверное число: {part} — пропущено");
            }
        }

        numbers.RemoveAll(n => n < 0);
        numbers.Sort();

        Console.WriteLine(string.Join(", ", numbers));
    }
}
