using System.Collections.Generic;
using vMachine.Interfaces;

namespace vMachine.Services
{
  class VMachineService
  {
    private Inventory Inventory { get; set; }
    public List<string> Messages;

    public void PrintOptions()
    {
      Messages.Add("---Options---");
      int index = 1;
      foreach (var item in Inventory.Products)
      {
        Messages.Add(index.ToString() + ") " + item.GetInventoryLineItem());
        index++;
      }
      Messages.Add("What would you like to do? (a)dd money, (b)uy, or (q)uit?");
    }

    public float AddMoney()
    {
      Inventory.Credit += 0.25f;
      return Messages.Add(Inventory.Credit.ToString());
    }

    public VMachineService()
    {
      Inventory = new Inventory();
      Messages = new List<string>();
    }
  }
}