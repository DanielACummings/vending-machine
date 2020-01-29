using System.Collections.Generic;
using vMachine.Interfaces;

namespace vMachine.Models
{
  class Food : IPurchasable
  {
    public float Price { get; set; }
    public string Title { get; set; }
    public List<string> Ingredients { get; set; }
    int KCals { get; set; }

    public string GetInventoryLineItem()
    {
      return $"{Title}{(KCals)} -- {Price}";
    }

    public Food(float price, string title, List<string> ingredients, int kCals)
    {
      Price = price;
      Title = title;
      Ingredients = ingredients;
      KCals = kCals;
    }
  }
}