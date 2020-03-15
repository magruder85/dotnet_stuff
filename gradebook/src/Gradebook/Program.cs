using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
           var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
      
           var result = 0.0;
           foreach(double number in grades){
               result += number;
           }

           result /= grades.Count;
           System.Console.WriteLine($"The average grade is {result}.");

            if(args.Length > 0 ) {
                Console.WriteLine($"Hello {args[0]}!");
            } else {
                Console.WriteLine("This program would be a lot cooler with at least one argument.");
            }

        }
    }
}
