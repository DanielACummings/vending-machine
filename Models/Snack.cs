using System.Collections.Generic;
using vMachine.Interfaces;

namespace vMachine.Models
{
  class Snack : Food, IPurchasable
  {
    public Snack(float price, string title, int kCals) : base(price, title, kCals)
    { }
  }
}