using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] {12.7, 10.3, 6.11};
            var result = numbers[0];
            result += numbers[1];
            result += numbers[2];

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
