using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class Rectangle
    {
        // ----fields----
        private double height;
        private double width;

        // ----input methods----
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

        // ----constructor----
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        // ----properties----
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        // ----calculating methods----
        public double calculatePerimter
        {
            get { return 2 * (height + width); }
        }

        public double calculateArea
        {
            get { return height * width; }
        }

        // ----display methods----
        public String GetDisplayArea()
        {
            return  "Area:      " + calculateArea;
        }
        public String GetDisplayPerimeter()
        {
            return "Perimeter: " + calculatePerimter;
        }

    }

}

