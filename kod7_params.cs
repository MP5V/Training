using System; 
using System.Linq; 
using System.Collections.Generic; 
 
namespace HelloWorld; 
 
/*Условие:
C# PrintSum(params int[] numbers)

Выводит: "Сумма чисел: X" (или "Нет чисел", если пусто или null)

Примеры вызова:

PrintSum(1, 2, 3) → Сумма чисел: 6
PrintSum() → Нет чисел
PrintSum(10) → Сумма чисел: 10

Напиши метод + 4–5 вызовов в Main.*/
public static class Program
{
    static void PrintSum(params int[] numbers)
    {
        if (numbers == null || numbers.Length = 0)
        {
            return;
        }

        int summ = 0;

        foreach (int i in numbers)
        {
            summ += i;
        }
        Console.WriteLine(summ);
    }

    public static void Main() 
    {

        PrintSum(1, 2, 3);
        PrintSum();
        PrintSum(3);
    }
