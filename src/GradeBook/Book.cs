using System.Collections.Generic;

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

        public void AddGrade(double grade){
            grades.Add(grade);
        }
       private List<double> grades = new List<double>();
       private string name;
    }
}
