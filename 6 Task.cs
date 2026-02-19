using System;

public class MainClass
{
    public static void Main()
    {
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');

        int a = Convert.ToInt32(splitString[0]);
        int b = Convert.ToInt32(splitString[1]);
        int c = Convert.ToInt32(splitString[2]);
        int d = Convert.ToInt32(splitString[3]);

        int[] mas = new int[4];
        mas[0] = a;
        mas[1] = b;
        mas[2] = c;
        mas[3] = d;

        for (int i = 0; i < mas.Length - 1; i++)
        {
            for (int j = 0; j < mas.Length - 1 - i; j++)
            {
                if (mas[j] > mas[j + 1])
                {
                    int temp = mas[j];
                    mas[j] = mas[j + 1];
                    mas[j + 1] = temp;
                }
            }
        }


        int minValue = mas[0];
        int maxValue = mas[mas.Length - 1];

        Console.WriteLine($"Наименьшее число - {minValue}");
        Console.WriteLine($"Наибольшее число - {maxValue}");
    }
}
