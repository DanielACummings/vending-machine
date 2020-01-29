using System.Collections.Generic;

namespace vMachine.Models
{
  class Snacks : Food
  {
    public Snacks(float price, string title, List<string> ingredients, int kCals) : base(price, title, ingredients, kCals)
    { }
  }
}