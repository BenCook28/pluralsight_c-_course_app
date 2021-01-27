﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("test book");
            book.GradeAdded += OnGradeAdded;
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
                } else 
                {
                    try
                    {
                        grade = double.Parse(input);
                        book.AddGrade(grade);
                    }
                    catch(ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch(FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Make it a great day, or not, the choice is yours.");
                    }               
                }
            } while(done == false);

            var stats = book.GetStatistics();

            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The lowest grade is {stats.lowGrade}.");
            Console.WriteLine($"The highest grade is {stats.highGrade}.");
            Console.WriteLine($"The average grade is {stats.average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}
