using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
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
            Console.WriteLine("Calculating Rectangle's Area and Perimeter Program\n");

            // input
            double height = Rectangle.getHeight("Height: ");
            double width = Rectangle.getWidth("Width: ");

            Rectangle recA, recP;
            recA = new Rectangle(height, width);
            recP = new Rectangle(height, width);

            // display
            Console.WriteLine(  "--------------\n" +
                                recA.GetDisplayArea() + "\n" +
                                recP.GetDisplayPerimeter());

            Console.ReadLine();
        }
    }
}
