using System; 
using System.Linq; 
using System.Collections.Generic; 
 
namespace HelloWorld; 
 
/*TryDivide bool TryDivide(double a, double b, out double result)
Если b == 0 → return false, result = 0
Иначе result = a / b, return true*/

public static class Program
{
    static bool TryDivide(double a, double b, out double result)
    {
        if (b == 0 || b == null)
        {
            result = 0;
            return false;
        }
        else
        {
            result = a / b;
        }
        return true;
    }

    public static void Main() 
    {

        Console.WriteLine(TryDivide(0.3, 3.5, out double result));
    }
}
