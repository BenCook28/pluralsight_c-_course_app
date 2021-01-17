using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            double x;
            x = 34.1;

            double y;
            y = 18.3;

            if(args.Length > 0){
                Console.WriteLine($"Hello, {args[0]}!");
                Console.WriteLine(x + y);
            } 
            else{
                Console.WriteLine("Hello");
            }          
        }
    }
}
