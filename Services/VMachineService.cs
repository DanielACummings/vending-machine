using System;
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
      Messages.Add($"You have ${Inventory.Credit} to spend\n");
      Messages.Add("---Options---");
      int index = 1;
      foreach (var item in Inventory.Products)
      {
        Messages.Add(index.ToString() + ") " + item.GetInventoryLineItem());
        index++;
      }
      Messages.Add("\nYou can purchase an item by typing its number, (a)dd a dollar, or (q)uit");
    }

    public void AddDollar()
    {
      Inventory.Credit += 1.00f;
      PrintOptions();
    }

    public void Buy(int selection)
    {
      if (Inventory.Products[selection].Price > Inventory.Credit)
      {
        Messages.Add($"You don't have enough money to buy {Inventory.Products[selection].Title}");
      }
      else if (Inventory.Products[selection].Quantity < 1)
      {
        Messages.Add($"{Inventory.Products[selection].Title} out of stock");
      }
      else
      {
        Messages.Add($"Purchased: {Inventory.Products[selection].Title}");
        Inventory.Credit -= Inventory.Products[selection].Price;
        Inventory.Products[selection].Quantity--;
      }
    }

    public VMachineService()
    {
      Inventory = new Inventory();
      Messages = new List<string>();
    }
  }
}