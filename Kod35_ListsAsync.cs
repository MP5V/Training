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
using System;


/*Задача 34:Обработка списка задач
Дан список URL (или просто строк):
var urls = new[] { "url1", "url2", "url3", "url4" };
Напиши метод async Task<string> FetchAsync(string url) — имитирует запрос (Task.Delay(1000 * random) + 
return $"Данные с {url}")
В Main запусти все запросы параллельно, дождись всех с WhenAll и выведи длину каждого ответа.
Ожидаемый вывод:
url1: 12 символов
url2: 12 символов
...
Всего обработано: 4*/
class Program
{

    static async Task Main()
    {
        var urls = new[] { "url1", "url2", "url3", "url4" };
        Random rnd = new Random();


        async Task<string> FetchAsync(string url)
        {
            await Task.Delay(rnd.Next(1000, 5000));
            return $"Данные с {url}";
        }

        Task<string>[] fetchTasks = urls.Select(FetchAsync).ToArray();

        string[] results = await Task.WhenAll(fetchTasks);

        for (int i = 0; i < results.Length; i++)
        {
            Console.WriteLine($"{urls[i]}: {results[i].Length} символов");
        }

        Console.WriteLine($"Всего обработано: {results.Length}");
    }
}

