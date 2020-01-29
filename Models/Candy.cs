using System.Collections.Generic;

namespace vMachine.Models
{
  class Candy : Food
  {
    public Candy(float price, string title, List<string> ingredients, int kCals) : base(price, title, ingredients, kCals)
    { }
  }
}