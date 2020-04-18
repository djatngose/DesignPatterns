using System;

namespace StaticAndNonStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main method is executed");
            Example obj1 = new Example();
            Example obj2 = new Example();
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

    }

    class Example
    {
        static Example()
        {
            // Only executed one time in lifecycle of a class
            Console.WriteLine("static constructor is called");
        }
        public Example()
        {
            Console.WriteLine("non-static constructor is called");
        }
    }
}
