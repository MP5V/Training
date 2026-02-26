using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;


/*Задача 16: Queue<T> — очередь задач
Задача
Создай очередь строк (задачи).
Добавь в очередь 4 задачи ("Task 1", "Task 2", "Task 3", "Task 4").
Затем обработай (выведи и удали) первые две задачи, потом добавь новую "Task 5", и выведи оставшиеся.*/
class Program
{
    static void Main()
    {
        Queue<string> tasks = new Queue<string>();

        tasks.Enqueue("Task 1");
        tasks.Enqueue("Task 2");
        tasks.Enqueue("Task 3");
        tasks.Enqueue("Task 4");

        string deleted1 = tasks.Dequeue();
        string deleted2 = tasks.Dequeue();

        Console.WriteLine($"Отменено: {deleted1}");
        Console.WriteLine($"Отменено: {deleted2}");

        Console.WriteLine("Оставшиеся действия: " + string.Join(", ", tasks));
    }
}
