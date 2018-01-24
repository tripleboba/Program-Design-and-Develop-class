using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class MainClass
    {
        static void Main(string[] args)
        {
            MainClass rectangle = new MainClass();
            rectangle.Greeting();
        }

        public void Greeting()
        {
            // greeting
            Console.WriteLine("Calcuate Rectangle's Area and Perimeter Program\n");

            // input
            double height = Rectangle.getHeight("Height: ");
            double width = Rectangle.getWidth("Width : ");

            // display
            Console.WriteLine(  "----------------------" +
                                "\nArea:      " + Rectangle.getArea(height, width) +
                                "\nPerimeter: " + Rectangle.getPerimeter(height, width));
            Console.ReadLine();
        }
    }
}
