using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            var students = new List<(string Name, int GroupID)>
            {
                ("Anna", 1),
                ("Bob", 2),
                ("Charlie", 1)
            };

            var groups = new List<(int GroupID, string Name)>
            {
                (1, "A"),
                (2, "B")
            };

            var joinedList = students.Join(groups,
                s => s.GroupID,
                g => g.GroupID,
                (s, g) => new { StudentName = s.Name, GroupName = g.Name });

            foreach (var item in joinedList)
            {
                Console.WriteLine($"{item.StudentName}: {item.GroupName}");
            }
        }
    }
}
