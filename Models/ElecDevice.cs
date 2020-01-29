using vMachine.Interfaces;

namespace vMachine.Models
{
  class ElecDevice : IPurchasable
  {
    public int Quantity { get; set; }
    public float Price { get; set; }
    public string Title { get; set; }
    string PortType { get; set; }
    public string GetInventoryLineItem()
    {
      return $"{Title} ({PortType}) -- ${Price} -- {Quantity} in stock";
    }

    public ElecDevice(int quantity, float price, string title, string portType)
    {
      Quantity = quantity;
      Price = price;
      Title = title;
      PortType = portType;
    }
  }
}