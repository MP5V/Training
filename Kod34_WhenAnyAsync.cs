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


/*Задача 33:WhenAny — первая завершённая задача
Напиши две задачи:

Task<int> SlowTask() — Task.Delay(5000) + return 100
Task<int> FastTask() — Task.Delay(2000) + return 42

В Main жди первую завершённую с WhenAny и выведи её результат + сколько времени прошло (Stopwatch).*/
class Program
{

    static async Task Main()
    {
        async Task<int> SlowTask()
        {
            await Task.Delay(5000);
            return 100;
        }

        async Task<int> FastTask()
        {
            await Task.Delay(2000);
            return 42;
        }

        var firstTask = SlowTask();
        var secondTask = FastTask();

        var sw = Stopwatch.StartNew();
        Task firstFinished = await Task.WhenAny(firstTask, secondTask);

        int result = await (Task<int>)firstFinished;
        sw.Stop();
        Console.WriteLine($"Первая задача: {result} была выполнена за {sw.ElapsedMilliseconds}");
    }
}
