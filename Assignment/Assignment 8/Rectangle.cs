using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Rectangle
    {
        // fields
        private double height;
        private double width;

        // constructor
        public Rectangle() { }

        // medthod
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        // input methods
        public static double getHeight(String prompt)
        {
            Console.Write(prompt);
            return double.Parse(Console.ReadLine());
        }
        public static double getWidth(String prompt)
        {
            Console.Write(prompt);
            return double.Parse(Console.ReadLine());
        }

        // calulating A and P methods
        public static double getArea(double h, double w)
        {
            return h * w;
        }
        public static double getPerimeter(double h, double w)
        {
            return 2 * (h + w);
        }
    }
}
