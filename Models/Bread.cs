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

        public Bread()
        {
            Quantity = 0;
        }
        public static void BreadInfo()
        {
            Console.WriteLine("Here is our current selection");
        }
    }
}