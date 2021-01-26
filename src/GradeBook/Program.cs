using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("test book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.lowGrade}.");
            Console.WriteLine($"The highest grade is {stats.highGrade}.");
            Console.WriteLine($"The average grade is {stats.average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
