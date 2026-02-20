using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;


/*Задача 9: in + структура
Создай struct Point3D { public double X,Y,Z; }
Напиши метод double GetDistance(in Point3D p1, in Point3D p2)
(расстояние между двумя точками в 3D: sqrt((x2-x1)^2 + (y2-y1)^2 + (z2-z1)^2))*/
namespace testing
{
    public struct Point3D
    {
        public double X;
        public double Y;
        public double Z;

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }

    internal class Program
    {
        static double GetDistance(in Point3D p1, in Point3D p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            double dz = p2.Z - p1.Z;

            double distance = Math.Sqrt((dx * dx) + (dy * dy) + (dz * dz));
            return distance;
        }

        static void Main(string[] args)
        {
            Point3D a = new Point3D(1, 2, 3);
            Point3D b = new Point3D(4, 5, 6);
            double dist = GetDistance(in a, in b);

            Console.WriteLine($"Точка A: {a}");
            Console.WriteLine($"Точка B: {b}");
            Console.WriteLine($"Расстояние: {dist:F2}");
        }
    }
}
