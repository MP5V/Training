using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;


/*Задача 14: Dictionary<TKey, TValue> — подсчёт частоты
Задача
Дан массив строк (слова).
Подсчитай, сколько раз каждое слово встречается, и выведи слова и их частоту (в любом порядке).
Пример входа: "cat", "dog", "cat", "bird", "dog", "cat"
Ожидаемый вывод (пример): cat: 3 dog: 2 bird: 1*/
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите животных через пробел: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> AnimalsCount= new Dictionary<string, int>();

        foreach (var word in parts)
        {
            if (AnimalsCount.ContainsKey(word))
            {
                AnimalsCount[word]++;
            }
            else
            {
                AnimalsCount[word] = 1;
            }
        }

        Console.WriteLine("Частота слов:");
        foreach (var pair in AnimalsCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
