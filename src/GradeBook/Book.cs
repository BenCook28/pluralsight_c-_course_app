using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book
    {
        //constructor
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            } else
            {
                Console.WriteLine("Invalid Value");
            }
        }
        
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.highGrade = double.MinValue;
            result.lowGrade = double.MaxValue;
            result.average = 0.0;

            var index = 0;

            do
            {
                result.highGrade = Math.Max(grades[index], result.highGrade);
                result.lowGrade = Math.Min(grades[index], result.lowGrade);
                result.average += grades[index];
            } while(index <= grades.Count);
            
            result.average /= grades.Count;

            return result;
        }
       private List<double> grades;
       public string Name;
    }
}
