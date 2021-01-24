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
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {

        }
        
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.highGrade = double.MinValue;
            result.lowGrade = double.MaxValue;
            result.average = 0.0;

            foreach(var grade in grades)
            {
                result.highGrade = Math.Max(grade, result.highGrade);
                result.lowGrade = Math.Min(grade, result.lowGrade);
                result.average += grade;
            }
            result.average /= grades.Count;

            return result;
        }
       private List<double> grades;
       private string name;
    }
}
