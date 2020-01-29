using System;
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
      var key = Console.ReadKey();
      Console.Clear();
      var keyChar = key.KeyChar;
      switch (keyChar)
      {
        case 'q':
          _running = false;
          break;
        case 'a':
          Service.AddMoney();
          break;
        // case 'b':
        //   Service.Buy();
        //   break;
        default:
          Console.WriteLine("Invalid entry");
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