using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("test book");
            var input = "";
            var done = false;
            var grade = 0.0;
            do
            {
                Console.WriteLine("Enter grades. Press q to exist.");
                input = Console.ReadLine();
                if(input == "q"){
                    done = true;
                    continue;
                } else {
                    grade = double.Parse(input);
                    book.AddGrade(grade);
                }
            } while(done == false);

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.lowGrade}.");
            Console.WriteLine($"The highest grade is {stats.highGrade}.");
            Console.WriteLine($"The average grade is {stats.average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
