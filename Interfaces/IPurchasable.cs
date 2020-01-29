namespace vMachine.Interfaces
{
  interface IPurchasable
  {
    int Quantity { get; set; }
    float Price { get; set; }
    string Title { get; set; }
    string GetInventoryLineItem();
  }
}