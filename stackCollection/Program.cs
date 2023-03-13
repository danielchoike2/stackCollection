using System;
using System.Collections.Generic;

namespace FunwithStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates the members Stack
            Stack<string> food = new Stack<string>();
            //adding members
            food.Push("Pizza");
            food.Push("Ravioli");
            food.Push("Spaghetti");
            food.Push("Lasagna");
            food.Push("Stromboli");
          
            // Check for an item in the Stack
            Console.WriteLine("Would you like to look for a food item in the stack? (yes or no)");
            string answer = Console.ReadLine();
            while (answer == "yes")
            {
                Console.WriteLine("Enter the name of the food item you would like to search for");
                string foodName = Console.ReadLine();
                if (food.Contains(foodName))
                {
                    Console.WriteLine("That food item is apart of the stack.");
                }
                else
                {
                    Console.WriteLine("I am sorry, that food item is not apart of the stack.");
                }
                Console.WriteLine("Would you like to look for another food item (yes or no)");
                answer = Console.ReadLine();
            }
           
          
            string firstFood = food.Peek();   // retrieves the LAST item
            Console.WriteLine($"Would you like to remove {firstFood} from the end of the Stack (yes or no)?");
            answer = Console.ReadLine();
            while (answer == "yes")
            {
                food.Pop();  // Removes the LAST item
                firstFood = food.Peek();
                Console.WriteLine($"Would you like to remove {firstFood} from the end of the Stack (yes or no)?");
                answer = Console.ReadLine();
            }

            if (food.Peek() == null)
                Console.WriteLine("The Stack is empty");
            else
                Console.WriteLine($"You have {food.Count} food items left in the stack.");
               Console.WriteLine("");
                Console.WriteLine("The following names of the items are:");
            
            foreach (var m in food)
            {
                Console.WriteLine(m);
            }
        }
    }
}
