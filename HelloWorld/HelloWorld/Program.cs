using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // my code goes here

            Console.Write("\n\tWhat is your name buddy?\n\n\t");
            var name = Console.ReadLine();

            Console.WriteLine($"\n\nHello {name}");
            Console.WriteLine($"\n\nCurrent time is {DateTime.Now}");

            int dayOfYear = DateTime.Now.DayOfYear;
            Console.Write("Day of year: ");
            Console.WriteLine(dayOfYear);



        }
    }
}
