using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;


/*Задача 12:Интерфейс + реализация
Создай интерфейс IRepairable с методом Repair().
Создай класс Phone и класс Laptop, реализующие этот интерфейс.
В Main создай список объектов, которые реализуют IRepairable, и вызови Repair() у каждого.*/
namespace testing
{
    interface IRepairable
    {
        void Repair();
    }

    class Phone : IRepairable
    {
        public void Repair()
        {
            Console.WriteLine("Меня починить просто");
        }
    }

    class Laptop : IRepairable
    {
        public void Repair()
        {
            Console.WriteLine("Меня починить сложнее");
        }
    }

    class IPhone : IRepairable
    {
        public void Repair()
        {
            Console.WriteLine("Меня починить сложнее и дороже");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IRepairable[] devices = new IRepairable[] { new Phone(), new Laptop(), new IPhone() };

            foreach (var device in devices)
            {
                device.Repair();
            }
        }
    }
}
