using System.Collections.Generic;
using System;

namespace GradeBook
{
    class Book
    {
        //constructor
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var average = 0.0;
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
       private List<double> grades;
       private string name;
    }
}
