using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace testing
{
    record Circle(double Radius);
    record Rectangle(double Width, double Height);
    internal class Program
    {
        /*Switch expression + pattern matching
Напиши метод, который принимает object shape и возвращает площадь(double) :
Если Circle с Radius — π* r²
Если Rectangle с Width и Height — w* h
Иначе 0
Определи классы:record Circle(double Radius);
record Rectangle(double Width, double Height); Используй pattern matching в switch expression.*/

        static double findSquare(object shape) => shape switch
        {
            Circle circle => Math.PI * circle.Radius * circle.Radius,
            Rectangle rec => rec.Width * rec.Height,
            _ => 0
        };


        static void Main(string[] args)
        {
            var circle = new Circle(5);          // радиус 5
            var rect = new Rectangle(4, 6);      // ширина 4, высота 6

            Console.WriteLine("Площадь круга: " + findSquare(circle));   // ≈78.54
            Console.WriteLine("Площадь прямоугольника: " + findSquare(rect)); // 24
            Console.WriteLine("Площадь неизвестной фигуры: " + findSquare("не фигура")); // 0
        }
    }
}
