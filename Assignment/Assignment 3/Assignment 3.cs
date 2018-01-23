using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program computes the Fibonacci number for the nth term of the sequence");

            // input
            Console.Write("\nEnter the number of terms: ");
            int nTerm = int.Parse(Console.ReadLine());

            int p = -1;
            int s = 1;
            int r = 0;

            // output
            Console.WriteLine("\n----------------\nFirst " + nTerm + " terms of Fibonacci series are:");

            for (int i = 0; i <= nTerm; i++)

            {
                r = p + s;
                p = s;
                s = r;

                Console.WriteLine(r);
            }

            Console.ReadLine();
        }
    }
}
