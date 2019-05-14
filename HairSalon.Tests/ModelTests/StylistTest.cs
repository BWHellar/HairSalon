using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using MySql.Data.MySqlClient;

namespace HairSalon.Test
{
  [TestClass]
  public class StylistTest : IDisposable
  {
    public void Dispose()
    {
      Stylist.ClearAll();
    }
    public StylistTest()
    {
        DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=brendan_hellar_test;";
    }
    [TestMethod]
    public void Save_SaveStylistToDatabase_Stylist()
    {
      Stylist stylist = new Stylist("Jen");
      stylist.Save();

      List<Stylist> result = Stylist.GetStylist();

      Assert.AreEqual(1, result.Count);
    }
    [TestMethod]
    public void AddClient_AddClientToDatabase_Client()
    {
      Stylist stylist = new Stylist("Ben");
      stylist.Save();

      Client client = new Client("Jen");
      stylist.AddClient(client);
      List<Client> clients = stylist.GetClients();

      Assert.AreEqual(1, clients.Count);
    }

    [TestMethod]
    public void Delete_DeleteStylist_Stylist()
    {
      Stylist stylist = new Stylist("Ten");
      stylist.Save();

      stylist.Delete();

      List<Stylist> allStylists = Stylist.GetStylist();
      int result = allStylists.Count;

      Assert.AreEqual(0, result);
    }
  }
}
