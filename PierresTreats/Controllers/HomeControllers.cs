using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;

namespace PierresTreats.Controllers
{
  public class HomeControllers : Controller
  {
    private readonly PierresTreatsContext _db;
    public HomeControllers(PierresTreatsContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Treat> TreatList = _db.Treats.ToList();
      List<Flavor> FlavorList = _db.Flavors.ToList();
      ViewBag.Treats = TreatList;
      ViewBag.Flavors = FlavorList;
      return View();
    }
  }
}