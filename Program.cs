using System;

namespace Class2_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, there. Let me show you what I can do. " +
                              "Allow me to calculate the area of a rectangle for you." +
                              " Please provide a positive, whole number for each dimension: Length and width.");
            //Console.ReadLine();

            Console.Write("Please type the length of your rectangle: ");
            string x = Console.ReadLine();

            int x1 = int.Parse(x);

            Console.Write("Please type the width of your rectangle: ");
            string y = Console.ReadLine();

            int y1 = int.Parse(y);

            var z = x1 * y1;
            Console.WriteLine("The area of your rectangle is: " + z );
            Console.ReadLine();

        }
    }
}
