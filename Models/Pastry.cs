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
      Price = 0;

      if (quantity <= 2 || quantity % 2 == 0)
      {
        Price = quantity * 2;
      }
      else if (quantity % 3 == 0)
      {
        Price += 5;
        Console.WriteLine("There's a buy 3 for $5 sale happening now! Your total for " + quantity + " is $" + Price + ".");
      }
    }
  }
}