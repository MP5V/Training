using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Collections;


/*Задача 21:Дан массив строк (слова):
"cat dog cat bird dog cat bird"
Сгруппируй слова по их значению и выведи каждое слово и сколько раз оно встретилось (отсортируй по убыванию частоты).*/
class Program
{
    public class Animals
    {
        public string Type { get; set; }
    }
    static void Main()
    {
        Animals[] words = new Animals[]
        {
            new Animals {Type = "cat"},
            new Animals {Type = "dog"},
            new Animals {Type = "cat"},
            new Animals {Type = "bird"},
            new Animals {Type = "dog"},
            new Animals {Type = "cat"},
            new Animals {Type = "bird"},
        };

        var countWords = words.GroupBy(a => a.Type).Select(g => new { Animals = g.Key, Count = g.Count() });

        foreach (var item in countWords)
        {
            Console.WriteLine($"{item.Animals}: {item.Count}");
        }
        
    }
}
