using System;

public class MainClass
{
    public static void Main()
    {
        double bankDeposit = Convert.ToDouble(Console.ReadLine());
        double sum = 0.0;

        if (bankDeposit < 100)
        {
            sum += (bankDeposit * 0.05) + bankDeposit;
        } else
            if (bankDeposit >= 100 && bankDeposit <= 200)
            {
                sum += (bankDeposit * 0.07) + bankDeposit;
            } else
                if (bankDeposit > 200)
                {
                    sum += (bankDeposit * 0.1) + bankDeposit;
                };


        Console.WriteLine($"Сумма вклада после начисления процентов: {sum}");

    }
}
