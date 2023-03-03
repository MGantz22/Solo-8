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
    public ActionResult Create(string name, string genre)
    {
      Vendor newVendor = new Vendor(name);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.GetAll();
      return View(vendorList);
    }


}


}