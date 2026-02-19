using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace testing
{
    internal class Program
    {
        /*Relational patterns
Напиши функцию, которая классифицирует температуру (double t):
< 0 → "Freezing"
0..15 → "Cold"
15..25 → "Normal"
25 → "Hot"
Верни строку.*/
        static string FindTemperature(double t)
        {
            string result = t switch
            {
                < 0 => "Freezing",
                >= 0 and < 15 => "Cold",
                >= 15 and < 25 => "Normal",
                >= 25 => "Hot",
                _ => "Not temperature"
            };

            return result;
        }
       

        static void Main(string[] args)
        {
            Console.WriteLine(FindTemperature(15));   
            Console.WriteLine(FindTemperature(-7)); 
            Console.WriteLine(FindTemperature(30)); 
        }
    }
}
