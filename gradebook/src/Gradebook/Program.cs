using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Validate the args
            if(args.Length > 0 ) {
                // broke - composite formatting
                // Console.WriteLine("Hello " + args[0] + "!");
                // woke - string interpolation
                Console.WriteLine($"Hello {args[0]}!");               
            } else {
                Console.WriteLine("This program would be a lot cooler with at least one argument.");
            }

        }
    }
}
