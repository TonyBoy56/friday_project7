using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery 
{
    public class Program
    {
        // Create objects of Bread and Pastry classes //
        public static Bread typeA = new Bread();
        public static Pastry typeB = new Pastry();
        // Here will go initial text prompting the user for inputs //
        public static void Main()
        {
            Console.WriteLine("Hello! Welcome to Tony's Bakery!");
            Console.WriteLine("Here are our current options:");
            Console.WriteLine("Buy: [bread] [pastry] View Menus: [menus]");
            
            string response = Console.ReadLine();
            response = response.ToLower();
        }

        public static void CurrentOrder()
        {
            
        }

        // Takes input for number of loaves to purchase, and returns total. //
        public static int BreadForm()
        {
            Console.WriteLine("Please enter the number of loaves for your purchase.");
            string breadQuantity = Console.ReadLine();
            int breadQ = int.parse(breadQuantity);
            Bread breadOrder = new Bread(breadQ);
            int totalBread = breadOrder.Price;

            return totalBread;
        }
        // Takes input for number of pastries to order, and returns total. //
        public static int PastryForm()
        {
            Console.WriteLine("Please enter the number of pastries for your purchase.");
            string pastryQuantity = Console.ReadLine();
            int pastryQ = int.parse(pastryQuantity);
            Pastry pastryOrder = new Pastry(pastryQ);
            int totalPastry = pastryOrder.Price;

            return totalPastry;
        }
    }
}