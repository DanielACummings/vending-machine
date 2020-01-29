using System.Collections.Generic;
using vMachine.Interfaces;

namespace vMachine.Models
{
  class Snack : Food, IPurchasable
  {
    public Snack(int quantity, float price, string title, int kCals) : base(quantity, price, title, kCals)
    { }
  }
}