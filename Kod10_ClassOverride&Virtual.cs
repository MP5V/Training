using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;


/*Задача 10:Virtual vs new
Создай базовый класс Vehicle с virtual методом StartEngine().
Создай два потомка:

Car — override StartEngine() → "Завожу бензиновый мотор"
ElectricCar — new StartEngine() → "Запускаю электродвигатель"

В Main создай объекты через базовый тип и вызови StartEngine().*/
namespace testing
{
    class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Я просто двигатель");
        }
    }
    
    class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Завожу бензиновый мотор");
        }
    }

    class Electriccar : Vehicle
    {
        public new void StartEngine()
        {
            Console.WriteLine("Запускаю электродвигатель");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle Car = new Car();
            Vehicle ElectricCar = new Electriccar();

            Vehicle vehicle = new Vehicle();
            vehicle.StartEngine();

            Car.StartEngine();
            ElectricCar.StartEngine();

            ((Electriccar)ElectricCar).StartEngine();
        }
    }
}
