using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new double[3];
            numbers[0] = 1.1;
            numbers[1] = 1.1;
            numbers[2] = 1.1;

            if(args.Length > 0){
                Console.WriteLine($"Hello, {args[0]}!");
                System.Console.WriteLine(numbers[0] + numbers[1] + numbers[2]);
            } 
            else{
                Console.WriteLine("Hello");
            }          
        }
    }
}
