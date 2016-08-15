using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myAbacus.Models;

namespace myAbacus.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet]
    public ActionResult Index()
    {
      var model = new AbacusViewModel();

      return View("Adder", model);
    }

    [HttpPost]
    public ActionResult Calculate(AbacusViewModel model)
    {
      if (!ModelState.IsValid)
      {
        model.Sum = "";
        return View("Adder", model);
      }

      var addr = new Adder(model.LeftSide, model.RightSide);
      model.Sum = addr.Sum;

      return View("Adder", model);
    }
  }
}