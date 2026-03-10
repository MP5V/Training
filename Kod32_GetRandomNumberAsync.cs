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
using System.Threading.Tasks;


/*Задача 31:Метод с возвратом значения
Напиши async Task<int> GetRandomNumberAsync(), который:

Ждёт 1 секунду
Возвращает случайное число от 1 до 100

В Main вызови его 3 раза подряд (с await) и выведи суммы всех трёх чисел.*/
class Program
{

    static async Task Main()
    {
        async Task<int> GetRandomNumberAsync()
        {
            await Task.Delay(1000);
            Random rnd = new Random();
            int random = rnd.Next(1, 15);
            return random;
        }

        int ran1 = await GetRandomNumberAsync();
        Console.WriteLine($"Первое число: {ran1}");
        int ran2 = await GetRandomNumberAsync();
        Console.WriteLine($"Второе число: {ran2}");
        int ran3 = await GetRandomNumberAsync();
        Console.WriteLine($"Третье число: {ran3}");

        int sum = ran1 + ran2 + ran3;  // ← опечатка: ranb3 вместо ran3
        Console.WriteLine($"Сумма: {sum}");
    }
}

