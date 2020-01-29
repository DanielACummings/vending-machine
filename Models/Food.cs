using System.Collections.Generic;
using vMachine.Interfaces;

namespace vMachine.Models
{
  class Food : IPurchasable
  {
    public float Price { get; set; }
    public string Title { get; set; }
    int KCals { get; set; }

    public string GetInventoryLineItem()
    {
      return $"{Title} ({KCals} KCals) -- ${Price}";
    }

    public Food(float price, string title, int kCals)
    {
      Price = price;
      Title = title;
      KCals = kCals;
    }
  }
}