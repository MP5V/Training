using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;


/*Задача 17: Stack<T> — стек для undo
Задача
Создай стек строк (история действий).
Добавь в стек действия: "Открыл файл", "Написал текст", "Удалил слово", "Сохранил".
Затем сделай 2 undo (Pop) и выведи, какое действие отменено и что осталось в стеке.*/
class Program
{
    static void Main()
    {
        Stack<string> undo = new Stack<string>();

        undo.Push("Открыл файл");
        undo.Push("Написал текст");
        undo.Push("Удалил");
        undo.Push("Сохранил");

        string first = undo.Pop();
        Console.WriteLine($"Отменено: {first}");
        string second = undo.Pop();
        Console.WriteLine($"Отменено: {second}");

        Console.WriteLine("Оставшиеся действия: " + string.Join(", ", undo));
    }
}
