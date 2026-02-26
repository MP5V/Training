using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;


/*Задача 19:Any / All
Дан List<int> scores = { 85, 92, 78, 95, 60 };
Проверь и выведи:

Есть ли хотя бы один балл > 90?
Все ли баллы >= 60?*/
class Program
{
    static void Main()
    {
        List<int> scores = new List<int> { 85, 92, 78, 95, 60 };
        bool any90 = scores.Any(x => x > 90);
        bool all60 = scores.All(x => x >= 60);

        Console.WriteLine($"Есть балл > 90: {(any90 ? "Да" : "Нет")}");
        Console.WriteLine($"Все баллы >= 60: {(all60 ? "Да" : "Нет")}");
    }
}
