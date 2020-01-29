using vMachine.Interfaces;

namespace vMachine.Models
{
  class Electronics : IPurchasable
  {
    public float Price { get; set; }
    public string Title { get; set; }
    string PortType { get; set; }
    public string GetInventoryLineItem()
    {
      return $"{Title}{(PortType)} -- {Price}";
    }

    public Electronics(float price, string title, string portType)
    {
      Price = price;
      Title = title;
      PortType = portType;
    }
  }
}