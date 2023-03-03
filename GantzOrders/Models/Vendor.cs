using System;
using System.Collections.Generic;

namespace GantzOrders.Models
{
  public class Vendor
  {
    public string Name {get; set;}
    public static int Indexer {get;set;} =0;
    public int Id {get;}
    private static List<Vendor> _instances = new List<Vendor>{};
    public List<Order> Inventory {get;set;}

    public Vendor (string name)
    {
      Name = name;
      Id = Indexer;
      Vendor.Indexer ++;
      _instances.Add(this);
      Inventory = new List<Order>{};
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static Vendor Find(int vendorId)
    {
      foreach(Vendor item in _instances)
      {
        if(vendorId == item.Id)
        {
          return item;
        }
      }
      return new Vendor("artist not Found");
    }
  }
}