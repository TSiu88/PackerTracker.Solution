using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/item")]
    public ActionResult Item() { return View(); }

    [HttpGet("/form")]
    public ActionResult Form() { return View(); }

    [HttpPost("/form")]
    public ActionResult Form(string param) 
    { 
      Item myItem = new Item(param);
      return View(); 
    }

  }
}