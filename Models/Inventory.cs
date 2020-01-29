using System.Collections.Generic;

namespace vMachine.Interfaces
{
  class Inventory
  {
    public List<IPurchasable> Products;
    public float Credit;

    public Inventory()
    {
      Products = new List<IPurchasable>();
    }
  }
}