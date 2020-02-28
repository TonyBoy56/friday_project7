using System;
using System.Collections.Generic;
using Bakery;
using Bakery.Models;

namespace Bakery.Models
{
    // Create Bread class inside of Bakery namespace //
    public class Bread
    {
        // Give class auto-implemented property of 'Quantity' //
        // 'get' 'set' preform same behavior as privatizing. //
        public int Quantity { get; set; }
        public int Price { get; set; }

        public Bread(int quantity)
        {
            Quantity = quantity;
            Price = quantity * 2;
        }
        public static void BreadInfo()
        {
            Console.WriteLine("Our current selection is only limited to one loaf, for the time being. Would you like to buy a loaf of bread?");
            Console.WriteLine("[yes] [no]");
            string reponseBread = Console.ReadLine();
            reponseBread = reponseBread.ToLower();
            if (reponseBread == "yes")
            {

            }

        }
        public static void BuyThisBread()
        {
            Console.WriteLine("How much of this loaf would you like to purchase?");
            Console.WriteLine("Bread is $2/loaf.");
            int Amount = 
        }
    }
}