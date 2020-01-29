namespace vMachine.Interfaces
{
  interface IPurchasable
  {
    float Price { get; set; }
    string Title { get; set; }
    string GetInventoryLineItem();
  }
}