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

        public void AddLetterGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }   
        }

        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            } else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }
        
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.highGrade = double.MinValue;
            result.lowGrade = double.MaxValue;
            result.average = 0.0;

            for(var index= 0; index < grades.Count; index++)
            {
                result.highGrade = Math.Max(grades[index], result.highGrade);
                result.lowGrade = Math.Min(grades[index], result.lowGrade);
                result.average += grades[index];
            } 

            result.average /= grades.Count;

            switch(result.average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }
       private List<double> grades;
       public string Name;
    }
}
