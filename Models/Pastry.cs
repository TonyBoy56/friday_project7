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

    public Pastry (int quantity) 
    {
      Quantity = quantity;
      Price = quantity * 2;

      if (quantity % 3 == 0)
      {
        Price -= 1;
        Console.WriteLine("There's a buy 3 for $5 deal today! Your quantity is " + quantity + " for the price of " + Price + ".");
      }
    }
  }
}