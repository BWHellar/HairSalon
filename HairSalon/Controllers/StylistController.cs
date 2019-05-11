using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistController : Controller
  {

    [HttpGet("/stylist")]
    public ActionResult Index()
    {
      List<Stylist> allStylist = Stylist.GetAll();
      return View(allStylist);
    }

    [HttpPost("/stylist/create")]
    public ActionResult Create(string name)
    {
      Stylist newStylist = new Stylist(stylist);
      newStylist.Save();
      return RedirectToAction("Index");
    }


    [HttpGet("/stylist/{stylistId}")]
    public ActionResult Show(int stylistId)
    {
      Stylist model = Stylist.Find(stylistId);
      return View(model);
    }

    [HttpGet("/stylist/{stylistId}/client")]
    public ActionResult Create(int stylistId, string clientDescription)
    {
      Stylist stylist = Stylist.Find(stylistId);

      Client client = new Client(clientDescription);
      stylist.AddClient(client);

      return RedirectToAction("Show");
    }
  }
}
