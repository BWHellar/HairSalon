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

    [HttpGet("/stylist/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/stylist")]
    public ActionResult Create(string stylist)
    {
      Stylist newStylist = new Stylist(stylist);
      List<Stylist> allStylist = Stylist.GetAll();
      return View("View", allStylist);
    }

    [HttpGet("/stylist/{stylistId}")]
    public ActionResult Show(int stylistId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Stylist selectedStylist = Stylist.Find(stylistId);
      List<Client> stylistClient = selectedStylist.GetClient();
      model.Add("stylist", selectedStylist);
      model.Add("client", stylistClient);
      return View(model);
    }

    [HttpGet("/stylist/{stylistId}/client")]
    public ActionResult Create(int stylistId, string clientDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Stylist foundStylist = Stylist.Find(stylistId);
      Client newClient = new Client(clientDescription);
      foundStylist.AddClient(newClient);
      List<Client> stylistClient = foundStylist.GetClient();
      model.Add("client", stylistClient);
      model.Add("stylist", foundStylist);
      return View("Show", model);
    }
  }
}
