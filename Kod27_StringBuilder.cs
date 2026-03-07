using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Collections;
using System.Text;


/*Задача 27:StringBuilder + форматирование
Создай StringBuilder и добавь в него 1000 чисел от 1 до 1000 через запятую без пробелов в конце.
Выведи длину итоговой строки.*/
class Program
{
    static void Main()
    {
        var sb = new StringBuilder();

        for (int i = 0; i < 1000; i++)
        {
            sb.Append($"{i + 1}, ");
        }

        sb.Remove(sb.Length - 2, 2); 
        Console.WriteLine(sb.ToString());
        Console.WriteLine($"Длина итоговой строки: {sb.Length}");
    }
}

