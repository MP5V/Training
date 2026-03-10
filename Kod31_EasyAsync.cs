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


/*Задача 31:Самый простой async-метод (задержка)
Напиши метод async Task SayHelloAsync(), который:

Выводит "Привет, начинаю..."
Ждёт 2 секунды (Task.Delay)
Выводит "Готово!"

Вызови его из Main с await.*/
class Program
{

    static async Task Main()
    {
        static async Task<string> SayHello()
        {
            Console.WriteLine("Привет! Начинаю...");
            await Task.Delay(2000);
            return "Готово!";
        }

        string result = await SayHello();
        Console.WriteLine(result);
    }
}

