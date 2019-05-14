using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using MySql.Data.MySqlClient;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientTest : IDisposable
  {

    public void Dispose()
    {
      Stylist.ClearAll();
    }

    public ClientTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=brendan_hellar_test;";
    }

    [TestMethod]
    public void Equals_MatchesClientsAndId_True()
    {
        Client client1 = new Client("TinyTim", 2);
        Client client2 = new Client("TinyTim", 2);

        Assert.AreEqual(client1, client2);
    }
    [TestMethod]
    public void Name_NameIsClient_String()
    {
        Client client = new Client("TinyTim");
        string result = client.Name;

        Assert.AreEqual("TinyTim", result);
    }
    [TestMethod]
    public void Id_IdIsClient_Id()
    {
        Client client = new Client("TinyTim", 5, 1);
        int result = client.Id;

        Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void StylistId_StylistIdIsClient_StylistId()
    {
        Client client = new Client("TinyTim", 10, 1);
        int result = client.StylistId;

        Assert.AreEqual(1, result);
    }
  }
}
