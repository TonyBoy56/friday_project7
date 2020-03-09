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

      if (quantity % 3 == 0)
      {
        Price -=5;
        Console.WriteLine("There's a buy 2 get 1 free sale! The quantity of your bread is " + quantity + " for the price of " + Price);
      }
      else if (quantity % 2 == 0)
      {
        quantity += 1;
        Console.WriteLine("There's a buy 2 get 1 free sale! The quantity of your bread is " + quantity + " for the price of " + Price);
      }
    }
  }
}