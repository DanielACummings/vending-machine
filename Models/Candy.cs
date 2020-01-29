using System.Collections.Generic;
using vMachine.Interfaces;

namespace vMachine.Models
{
  class Candy : Food, IPurchasable
  {
    public Candy(float price, string title, int kCals) : base(price, title, kCals)
    { }
  }
}