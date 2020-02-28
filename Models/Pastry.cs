using System;
using System.Collections.Generic;
using Bakery;
using Bakery.Models;

namespace Bakery.Models
{
    public class Pastry
    {
        public int Quantity { get; set; }

        public Pastry()
        {
            Quantity = 0;
        }
        public static void BreadInfo()
        {
            Console.Write("Here is our current selection")
        }
    }
}