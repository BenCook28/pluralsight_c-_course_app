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

            var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var average = 0.0;
            var lowTest = 0.0;
            foreach(var grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
                lowGrade = Math.Min(grade, lowGrade);
                result += grade;
                average = result / grades.Count;
            }
            Console.WriteLine($"The average is {average:N2}.");
            Console.WriteLine($"The highest grade is {highGrade}.");
            Console.WriteLine($"The lowest grade is {lowGrade}.");      
        }
    }
}
