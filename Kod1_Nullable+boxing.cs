using System; 
using System.Linq; 
using System.Collections.Generic; 
 
namespace HelloWorld; 
 
/*Nullable + boxing
Напиши метод, который принимает object и возвращает int?: если внутри boxed int — верни его, если null — null, иначе null.C#int? UnboxToNullable(object value) { ... }Тесты:
UnboxToNullable(42) → 42
UnboxToNullable(null) → null
UnboxToNullable("text") → null
UnboxToNullable(new int?(100)) → 100 (boxing nullable)*/

public static class Program
{
    static int? UnboxToNullable(object value)
    {
        if (value is int i)
            return i;
        return null;

    }

    public static void Main() 
    {
        Console.WriteLine("Тест 1: " + UnboxToNullable(42));
        Console.WriteLine("Тест 2: " + UnboxToNullable(null));
        Console.WriteLine("Тест 3: " + UnboxToNullable("text"));
        Console.WriteLine("Тест 4: " + UnboxToNullable(new int?(100)));

    }
}
