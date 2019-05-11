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
      List<Stylist>showAllStylist = Stylist.GetStylist();
      return View(showAllStylist);
    }


    [HttpPost("/stylist/{id}/clients/new")]
    public ActionResult Create(string clientName, int id)
    {
      Stylist stylist = Stylist.Find(id);

      Client client = new Client(clientName);
      stylist.AddClient(client);

      return RedirectToAction("Show");
    }


    [HttpGet("/stylist/{id}")]
    public ActionResult Show(int id)
    {
      Stylist model = Stylist.Find(id);
      return View(model);
    }

    [HttpPost("/stylist/new")]
    public ActionResult Create(string name)
    {
      Stylist stylist = new Stylist(name);
      stylist.Save();

      return RedirectToAction("Index");
    }


  }
}
