using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery 
{
    public class Program
    {
        public static void Main()
        {
            string response = CurrentOrder();
            PlaceOrder(response);
        }

        public static string CurrentOrder()
        {
            Console.WriteLine("Hello! Welcome to Tony's Bakery!");
            Console.WriteLine("Here are our current options:");
            Console.WriteLine("Buy: [bread] [pastry]");
            
            string response = Console.ReadLine();
            return response;
            // response = response.ToLower();
        }

        public static void PlaceOrder(string response)
        {
            if (response.ToLower() == "bread")
            {
                Console.WriteLine("How much would you like to purchase?");
                int totalBread = BreadForm();
                Console.WriteLine("Your total for bread is $" + totalBread + ".");
                AddToBasket();
                // if (addMore.ToLower() == "bread")
                // {
                //     AddToBasket(addMore);
                // }
                // // AddToBasket();
            }

            else if (response.ToLower() == "pastry")
            {
                Console.WriteLine("How much would you like to purchase?");
                int totalPastry = PastryForm();
                Console.WriteLine("Your total for pastries are $" + totalPastry + ".");
            }
        }

        public static void AddToBasket()
        {
            Console.WriteLine("Would you like to add anything else to your purchase?");
            Console.WriteLine("Buy: [bread] [pastry] [checkout]");
            string addMore = Console.ReadLine();
            if (addMore.ToLower() == "bread")
            {
                PlaceOrder("bread");
            }
            else if (addMore.ToLower() == "pastry")
            {
                PlaceOrder("pastry");
            }
            else if (addMore.ToLower() == "checkout") 
            {
                
            }
        }

        // Takes input for number of loaves to purchase, and returns total. //
        public static int BreadForm()
        {
            Console.WriteLine("Please enter the number of loaves for your purchase.");
            string breadQuantity = Console.ReadLine();
            int breadQ = Int32.Parse(breadQuantity);
            Bread breadOrder = new Bread(breadQ);
            int totalBread = breadOrder.Price;

            return totalBread;
        }
        // Takes input for number of pastries to order, and returns total. //
        public static int PastryForm()
        {
            Console.WriteLine("Please enter the number of pastries for your purchase.");
            string pastryQuantity = Console.ReadLine();
            int pastryQ = Int32.Parse(pastryQuantity);
            Pastry pastryOrder = new Pastry(pastryQ);
            int totalPastry = pastryOrder.Price;

            return totalPastry;
        }
    }
}