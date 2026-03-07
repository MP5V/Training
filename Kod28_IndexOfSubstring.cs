using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Collections;
using System.Text;


/*Задача 28:IndexOf + Substring
Дан email (ввод с клавиатуры).
Вырежи и выведи только домен (всё после @).*/
class Program
{
    static void Main()
    {
        Console.Write("Введите email: ");
        string email = Console.ReadLine()?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(email))
        {
            Console.WriteLine("Email не введён");
            return;
        }

        if (email.Contains('@'))
        {
            int atIndex = email.IndexOf('@');
            string domain = email.Substring(atIndex + 1);

            if (string.IsNullOrEmpty(domain))
            {
                Console.WriteLine("Некорректный email: после @ ничего нет");
            }
            else
            {
                Console.WriteLine($"Домен: {domain}");
            }
        }
        else
        {
            Console.WriteLine("Некорректный email: отсутствует символ '@'");
        }
    }
}

