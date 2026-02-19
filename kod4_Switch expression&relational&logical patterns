using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace testing
{
    internal class Program
    {
        /*Задача 4: Классификация возраста
Напиши метод string GetAgeCategory(int age), который возвращает категорию возраста:

age < 0 → "Invalid age"
0 ≤ age ≤ 12 → "Child"
13 ≤ age ≤ 17 → "Teenager"
18 ≤ age ≤ 64 → "Adult"
age ≥ 65 → "Senior"

Используй switch expression с relational и logical patterns.*/
        static string GetAgeCategory(int age)
        {
             return age switch
            {
                < 0 => "Invalid age",
                >= 0 and <= 12 => "Child",
                >= 13 and <= 17 => "Teenager",
                >= 18 and <= 64 => "Adult",
                >= 65 and <= 100 => "Senior",
                _ => "Not age"
            };
        }
       

        static void Main(string[] args)
        {
            Console.WriteLine(GetAgeCategory(15));   
            Console.WriteLine(GetAgeCategory(-7)); 
            Console.WriteLine(GetAgeCategory(89));
        }
    }
}
