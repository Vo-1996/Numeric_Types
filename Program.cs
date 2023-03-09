using System;

namespace Numeric_Types
{
    class Program
    {
        public static void Main(string[] args)
        {
            double length;
            double width;
            double area;
            string input;

            Console.WriteLine("The length of rectangle is: ");
            input = Console.ReadLine();
            length = double.Parse(input);

            Console.WriteLine("The width of rectangle is: ");
            input = Console.ReadLine();
            width = double.Parse(input);

            area = (length * width);
            Console.WriteLine("The area of the rectangle is: " + area);
            Console.ReadLine();
        }
    }
}