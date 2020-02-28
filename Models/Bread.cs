using System;
using System.Collections.Generic;
using Bakery;
using Bakery.Models;

namespace Bakery.Models
{
    public class Bread
    {
        public int Quantity { get; set; }
        public int Price { get; set; }

        public Bread(int quantity)
        {
            Quantity = quantity;
            Price = quantity * 5;
        }
    }
}