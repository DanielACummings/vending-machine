using System.Collections.Generic;
using vMachine.Interfaces;

namespace vMachine.Models
{
  class Candy : Food, IPurchasable
  {
    public Candy(int quantity, float price, string title, int kCals) : base(quantity, price, title, kCals)
    { }
  }
}