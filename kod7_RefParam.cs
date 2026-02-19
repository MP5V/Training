using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace testing
{
    internal class Program
    {
        /*Задача 6:Swap с ref
Напиши обобщённый метод void Swap<T>(ref T a, ref T b)
В Main поменяй два int и две string.*/

        static void Swap<T>(ref T x, ref T y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        static void Main(string[] args)
        {
            int a = 1;
            int b = 11;

            string c = "Hello";
            string d = "Hi";

            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}, b = {b}");

            Swap(ref c, ref d);
            Console.WriteLine($"c = {c}, d = {d}");
        }
    }
}
