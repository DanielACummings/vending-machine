using System;
using vMachine.Interfaces;
using vMachine.Services;

namespace vMachine.Controllers
{
  class VMachineController
  {
    private VMachineService Service { get; set; }
    private bool _running = true;
    public void Run()
    {
      Service.PrintOptions();
      while (_running)
      {
        PrintMessages();
        GetUserInput();
      }
      Console.Clear();
      Console.WriteLine("Goodbye");
    }

    private void GetUserInput()
    {
      var selection = Console.ReadLine();
      Console.Clear();
      switch (selection)
      {
        case "q":
          _running = false;
          break;
        case "a":
          Service.AddDollar();
          break;
        default:
          if (int.TryParse(selection, out int num))
          {
            Service.Buy(num - 1);
          }
          else
          {
            Console.WriteLine("Invalid entry");
          }
          Service.PrintOptions();
          break;
      }
    }

    private void PrintMessages()
    {
      foreach (string message in Service.Messages)
      {
        Console.WriteLine(message);
      }
      Service.Messages.Clear();
    }

    public VMachineController()
    {
      Service = new VMachineService();
    }
  }
}