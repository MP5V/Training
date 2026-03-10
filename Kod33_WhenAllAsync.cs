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
/*Задача 32:Параллельные задачи — WhenAll
Напиши 3 асинхронных метода:
Task<string> GetGoogleAsync() — имитирует запрос к Google (Task.Delay(3000) + return "Google OK")
Task<string> GetYandexAsync() — Task.Delay(2000) + "Yandex OK"
Task<string> GetGitHubAsync() — Task.Delay(1000) + "GitHub OK"
В Main запусти все три параллельно с WhenAll и выведи результаты по завершении всех.*/
class Program
{
    static async Task Main()
    {
        async Task<string> GetGoogleAsync()
        {
            await Task.Delay(3000);
            return "Google OK";
        }
        async Task<string> GetYandexAsync()
        {
            await Task.Delay(2000);
            return "Yandex OK";
        }
        async Task<string> GetGitHubAsync()
        {
            await Task.Delay(1000);
            return "GitHub OK";
        }
        var firstTask = GetGoogleAsync();
        var secondTask = GetYandexAsync();
        var thirdTask = GetGitHubAsync();
        string[] results = await Task.WhenAll(firstTask, secondTask, thirdTask);
       
        foreach (var item in results)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Все задачи выполнены!");
    }
}
