using Microsoft.AspNetCore.Mvc;


namespace GantzOrders.controller
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index() 
    {
      return View();
    }

  }
}
