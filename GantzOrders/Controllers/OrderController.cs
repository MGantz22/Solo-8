using Microsoft.AspNetCore.Mvc;
using GantzOrders.Models;
using System.Collections.Generic;

namespace GantzOrders.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendor/{vendorId}/inventory/new")] 
    public ActionResult New(int vendorId)
    {
      Vendor targetVendor = Vendor.Find(vendorId);
      return View (targetVendor);
    }

    [HttpPost("/vendor/{pathwayVendorId}/order")]
    public ActionResult Create(int pathwayVendorId, string inventoryName)
    {
      Vendor targetVendor = Vendor.Find(pathwayVendorId);
      Order newOrder = new Order(inventoryName, pathwayVendorId);
      return Redirect($"/vendors/{pathwayVendorId}");
      
    }
    
  }
}