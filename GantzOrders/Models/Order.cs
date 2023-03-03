using System.Collections.Generic;


namespace MusicOrganizer.Models
{
  public class Order
  {
    public string Name { get; set; }
    public static int Indexer { get; set; } =0;
    public int Id {get;}
    private static List<Order> _instances = new List<Order>{};
    // public List<Songs> Songs {get;set;} 

    public Order(string name, int orderId)
    {
      Name = name;
      Id = Indexer;
      Order.Indexer ++;
      _instances.Add(this);
      Vendor targetVendor = Vendor.Find(vendorId);
      targetVendor.Vendors.Add(this);
    }
  }
}