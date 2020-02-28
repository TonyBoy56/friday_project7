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
        // public static void OrderForm()
        // {
        //     Console.WriteLine("For the sake of keeping things organized, could we have a name for this order?");
        //     string name = Console.ReadLine();
        // }
    }
}