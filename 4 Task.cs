using System;

public class MainClass
{
    public static void Main()
    {
        int num = Int32.Parse(Console.ReadLine()); // Запрашиваем ввод из консоли и вытягиваем из него число

        if ( num % 2 == 0 ) 
        {
            Console.WriteLine("EVEN");
        }
        else
        {
            Console.WriteLine("ODD");
        }

    }
}
