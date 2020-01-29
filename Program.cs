using System;
using vMachine.Controllers;

namespace vMachine
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      var vMC = new VMachineController();
      vMC.Run();
    }
  }
}
