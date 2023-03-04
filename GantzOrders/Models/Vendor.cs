using System;
using System.Collections.Generic;

namespace GantzOrders.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get;set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor>{};
    public List<Order> Orders { get;set; }

    public Vendor (string name, string description)
    {
      Name = name;
      Description = description;
      Id = _instances.Count;
      _instances.Add(this);
      Orders = new List<Order>{};
    }
    public static void clearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId];
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}