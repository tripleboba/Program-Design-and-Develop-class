using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate A Rectangle's Area and Perimeter\n");

            // input
            Console.Write("Rectangle's Width:  ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("            Length: ");
            double length = double.Parse(Console.ReadLine());

            // output
            Console.WriteLine(  "\n----------------------------" +
                                "\nArea: " + CalculateArea(width, length) +
                                "\nPerimeter: " + CalculatePerimeter(width, length));

            Console.ReadLine();
        }

        // methods
        public static double CalculateArea(double width, double length)
        {
            return width * length;
        }
        public static double CalculatePerimeter(double width, double length)
        {
            return (width + length) * 2;
        }
    }
}
