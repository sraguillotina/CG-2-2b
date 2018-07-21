using System;

namespace Class2_HelloWorldGreet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            Console.Write("Type your name: ");
            string name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Hello, " + name + ".");
            Console.ReadLine();

        }
    }
}
