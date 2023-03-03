using Microsoft.AspNetCore.Mvc;
using GantzOrders.Models;
using System.Collections.Generic;

namespace GantzOrders.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendor/{vendorId}/orders/new")] 
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View (Vendor);
      }

    [HttpPost("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(venforId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Model.Add("order", order);
      Model.Add("vendor", vendor);
      return View (model);
    }
    
  }
}