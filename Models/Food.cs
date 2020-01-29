using System.Collections.Generic;
using vMachine.Interfaces;

namespace vMachine.Models
{
  class Food : IPurchasable
  {
    public int Quantity { get; set; }
    public float Price { get; set; }
    public string Title { get; set; }
    int KCals { get; set; }

    public string GetInventoryLineItem()
    {
      return $"{Title} ({KCals} KCals) -- ${Price} -- {Quantity} in stock";
    }

    public Food(int quantity, float price, string title, int kCals)
    {
      Quantity = quantity;
      Price = price;
      Title = title;
      KCals = kCals;
    }
  }
}