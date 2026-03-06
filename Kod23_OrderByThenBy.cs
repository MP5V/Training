using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public class Order
    {
        public string Customer { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var orders = new List<Order>
            {
                new Order { Customer = "Anna", Age = 25, City = "Moscow" },
                new Order { Customer = "Bob", Age = 30, City = "SPb" },
                new Order { Customer = "Charlie", Age = 25, City = "Moscow" },
                new Order { Customer = "Diana", Age = 28, City = "SPb" }
            };

            var finalSorted = orders.OrderBy(p => p.Age)
                                    .ThenBy(p => p.Customer);

            foreach (var groups in finalSorted)
            {
                Console.WriteLine($"{groups.Customer}: {groups.Age}");
            }
        }
    }
}
