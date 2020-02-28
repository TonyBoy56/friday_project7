using System;
using System.Collections.Generic;
using Bakery;
using Bakery.Models;

namespace Bakery.Models
{
    public class Pastry
    {
        public int Quantity { get; set; }
        public int Price { get; set; }

        public Pastry(int quantity)
        {
            Quantity = quantity;
            Price = quantity * 2;
        }
    }
}