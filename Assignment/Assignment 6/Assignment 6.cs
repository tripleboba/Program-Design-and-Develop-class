using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aPetShelterGreeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the animal shelter!\n");

            // input
            Console.Write("Your favorite animal: ");
            String animal = Console.ReadLine();

            String animalPluralLower = animal.Insert(animal.Length, "s").ToLower();

            // output
            Console.WriteLine(  "\ni love " + animalPluralLower +               "\n" +
                                "let's adopt several " + animalPluralLower +    "\n" +
                                animalPluralLower + " are wonderful animal.");

            Console.ReadLine();
        }
    }
}
