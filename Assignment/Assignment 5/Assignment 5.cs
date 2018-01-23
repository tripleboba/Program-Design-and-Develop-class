using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            // change color
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            // call method
            Program ShoppingList = new Program();
            ShoppingList.FoodList();

            Console.ReadLine();
        }

        public void FoodList()
        {
            //food list
            string[] foodList = new string[6];
            foodList[0] = "Apple";
            foodList[1] = "Muffin";
            foodList[2] = "Falafel";
            foodList[3] = "Yogurt";
            foodList[4] = "Fig";

            Console.WriteLine("Shopping Foods List:");
            for (int i = 0; i < (foodList.Length - 1); i++)
            {
                Console.WriteLine(foodList[i]);
            }

            Console.WriteLine();

            // input new food
            foodList[5] = GetInputfoodName("New food: ").ToUpper();

            // output
            Console.WriteLine("\nThe updated list is:");
            for (int i = 0; i < foodList.Length; i++)
            {
                Console.WriteLine(foodList[i]);
            }

            Console.ReadLine();
        }

        public static String GetInputfoodName(String prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

    }
}
