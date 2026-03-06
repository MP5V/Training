using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Collections;


/*Задача 22:Дан список объектов:
C#class Order
{
    public string Customer { get; set; }
    public decimal Amount { get; set; }
}

var orders = new List<Order>
{
    new() { Customer = "Anna", Amount = 100 },
    new() { Customer = "Bob", Amount = 200 },
    new() { Customer = "Anna", Amount = 150 },
    new() { Customer = "Bob", Amount = 50 },
    new() { Customer = "Anna", Amount = 300 }
};
Сгруппируй заказы по покупателю и выведи имя покупателя и общую сумму его заказов (отсортируй по убыванию суммы).*/
class Program
{
    public class Order
    {
        public string Customer { get; set; }
        public decimal Amount { get; set; }
    }
    static void Main()
    {
        var orders = new List<Order>
        {
            new Order { Customer = "Anna", Amount = 100 },
            new Order { Customer = "Bob", Amount = 200 },
            new Order { Customer = "Anna", Amount = 150 },
            new Order { Customer = "Bob", Amount = 50 },
            new Order { Customer = "Bob", Amount = 300 }
        };

        var countPrice = orders.GroupBy(a => a.Customer).Select(g => new { Customer = g.Key, TotalAmount = g.Sum(o => o.Amount) });
        var sortedPrics = countPrice.OrderBy(p => p.Customer);

        foreach (var item in sortedPrics)
        {
            Console.WriteLine($"{item.Customer}: {item.TotalAmount}");
        }
        
    }
}
