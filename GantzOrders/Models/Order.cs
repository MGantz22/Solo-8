using System.Collections.Generic;


namespace GantzOrders.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Details { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }
    public int Id {get;}
    private static List<Order> _instances = new List<Order>{};

    public Order(string title, string details, string price, string date)
    {
      Title = title;
      Details = details;
      Price = price;
      Date = date;
      Id = _instances.Count;
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
    
  }
}