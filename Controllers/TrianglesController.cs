using Microsoft.AspNetCore.Mvc;
using Triangles.Models;
using System.Collections.Generic;

namespace Triangles.Controllers
{
  public class TrianglesController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/results")]
    public ActionResult Results()
    {
      ModelState.Clear();
      Triangle newTriangle = new Triangle();
      newTriangle.SetSideA(int.Parse(Request.Form["side-a"]));
      newTriangle.SetSideB(int.Parse(Request.Form["side-b"]));
      newTriangle.SetSideC(int.Parse(Request.Form["side-c"]));
      string type = newTriangle.DetermineType(newTriangle);
      newTriangle.SetType(type);
      return View("Results", newTriangle);

    }

  }
}
