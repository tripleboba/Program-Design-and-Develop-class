using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Name input
            Console.Write("Name: ");
            String userName = Console.ReadLine();

            // Meal input
            Console.Write("Meal: ");
            String meal = Console.ReadLine();

            // Cost input
            Console.Write("Cost of Meal: $");
            double cost = double.Parse(Console.ReadLine());

            // Calculating total
            double tax = cost * 0.08;
            double tip = cost * 0.15;
            double total = tax + tip + cost;

            // Output
            Console.WriteLine(  "\n------------------\n" + 
                                userName.ToUpper() + ",\n\n" +
                                meal.ToUpper() + "'s cost is: $" + cost +
                                "\nTax: $" + tax + 
                                "\nTip: $" + tip +
                                "\n________________" + 
                                "\nTotal: $" + total );

            Console.ReadLine();

        }
    }
}
