using Microsoft.AspNetCore.Mvc;
using GantzOrders.Models;
using System.Collections.Generic;

namespace GantzOrders.Controllers
{

  public class VendorsController : Controller
  {
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.GetAll();
      return View(vendorList);
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }
    
    [HttpPost("vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDetails,  string orderDate, decimal orderPrice)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVender = Vendor.find(vendorId);
      Order newOrder = new Order (orderTitle, orderDetails, orderDate, orderPrice);
      FoundVenfor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("orders", foundVendor);
      return View("Show", model);
    }

  }
}