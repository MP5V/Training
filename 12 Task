using System;

public class MainClass
{
    public static void Main()
    {
        int x = 0;
        int y = 0;
        string input1;
        
        do
        {
            input1 = Console.ReadLine(); 
            
            if (input1 == "стоп")
                break;
            
            if (input1 == "вправо")
                x += 1;
            else if (input1 == "влево")
                x -= 1;
            else if (input1 == "вверх")
                y += 1;
            else if (input1 == "вниз")
                y -= 1;
            else
                Console.WriteLine("Неизвестная команда!");
        }while (true);
        
        Console.WriteLine($"Координаты: {x}, {y}");

    }
}
