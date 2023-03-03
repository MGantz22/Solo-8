using System.Collections.Generic;


namespace GantzOrders.Models
{
  public class Order
  {
    public string Name { get; set; }
    public static int Indexer { get; set; } =0;
    public int Id {get;}
    private static List<Order> _instances = new List<Order>{};
    // public List<Songs> Songs {get;set;} 

    public Order(string name, int vendorId)
    {
      Name = name;
      Id = Indexer;
      Order.Indexer ++;
      _instances.Add(this);
      Vendor targetVendor = Vendor.Find(vendorId);
      targetVendor.Inventory.Add(this);
    }
  }
}