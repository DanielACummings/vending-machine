using System.Collections.Generic;
using vMachine.Models;

namespace vMachine.Interfaces
{
  class Inventory
  {
    public List<IPurchasable> Products;
    public float Credit;

    private void Setup()
    {
      var android = new ElecDevice(3.00f, "Android(on sale)", "Mini-USB");
      var winPhone = new ElecDevice(4.00f, "Windows Phone(on sale)", "Micro-USB");
      var chips = new Snack(1.50f, "Sun Chips", 150);
      var dots = new Candy(0.75f, "Dots", 100);
      Products.AddRange(new IPurchasable[]{
        android, winPhone, chips, dots
      });
    }
    public Inventory()
    {
      Products = new List<IPurchasable>();
      Setup();
    }
  }
}