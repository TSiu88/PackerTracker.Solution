using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index() { return View(); }

    [HttpGet("/items/new")]
    public ActionResult New() { return View(); }

    [HttpPost("/items")]
    public ActionResult Create(string name, bool bought, bool packed, int price) 
    { 
      Item myItem = new Item(name, bought, packed, price);
      return View(); 
    }

  }
}
    