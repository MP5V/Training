using System;

public class MainClass
{
    public static void Main()
    {
        string[] signs = { "камень", "ножницы", "бумага" };
        Console.WriteLine("Выбирает первый игрок: 0 - камень, 1 - ножницы, 2 - бумага");
        int input1 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Первый игрок выбрал: {signs[input1]}");
        Console.WriteLine("Выбирает второй игрок: 0 - камень, 1 - ножницы, 2 - бумага");
        int input2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Второй игрок выбрал: {signs[input2]}");
  
                if (input1 == input2)
                    Console.WriteLine($"Результат: Ничья");
                else
                    if (input1 == 0 && input2 == 2)
                        Console.WriteLine($"Результат: Победил второй игрок");
                else
                    if (input1 == 2 && input2 == 0)
                        Console.WriteLine($"Результат: Победил первый игрок");
                else
                    if (input1 < input2)
                        Console.WriteLine($"Результат: Победил первый игрок");
                else
                    if (input1 > input2)
                        Console.WriteLine($"Результат: Победил второй игрок");
                else
                        Console.WriteLine($"Такого варианта не может быть!");

    }
}
