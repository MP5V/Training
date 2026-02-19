using System;

class Program
{
    static void Main()
    {
       
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int decimalNumber))
        {
            string hexadecimalNumber = DecimalToHex(decimalNumber);
            Console.WriteLine($"{hexadecimalNumber}");
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите корректное десятичное число.");
        }
    }

    static string DecimalToHex(int decimalNumber)
    {
        return decimalNumber.ToString("x");
    }
}
