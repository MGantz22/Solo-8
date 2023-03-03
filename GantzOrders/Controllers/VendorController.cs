using Microsoft.AspNetCore.Mvc;
using GantzOrders.Models;
using System.Collections.Generic;

namespace GantzOrders.Controllers
{

public class VendorController : Controller
{
  [HttpGet("/vendor/new")]
  public ActionResult New()
  {
    return View();
  }
}


}