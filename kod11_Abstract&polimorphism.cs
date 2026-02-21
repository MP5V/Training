using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;


/*Задача 11:Абстрактный класс + полиморфизм
Создай abstract class Animal с abstract методом MakeSound().
Создай потомков Dog, Cat, Bird — каждый реализует свой звук.
В Main создай массив Animal[] animals и вызови MakeSound() у каждого.*/
namespace testing
{
    abstract class Animal
    {
        public abstract void MakeSound();
    }
       
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Гав-гав!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Мяу-мяу!");
        }
    }

    class Bird : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Чирик-чирик!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];

            animals[0] = new Dog();
            animals[1] = new Cat();
            animals[2] = new Bird();

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].MakeSound();
            }
        }
    }
}
