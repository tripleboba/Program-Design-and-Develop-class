using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This program convert Numeric Grade to Letter Grade\n");

            // Input
            Console.Write("Numeric grade: ");
            int numberGrade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            String letterGrade;

            // Checking...
            if (numberGrade > 88)
                letterGrade = "A";
            
            else if (numberGrade >= 80 && numberGrade <= 88)
                letterGrade = "B";

            else if (numberGrade >= 68 && numberGrade <= 79)
                letterGrade = "C";

            else if (numberGrade >= 60 && numberGrade <= 67)
                letterGrade = "D";

            else
                letterGrade = "F";

            // Output
            Console.WriteLine("Grade " + letterGrade);
            Console.ReadLine();
        }
    }
}
