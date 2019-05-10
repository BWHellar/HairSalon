using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientTest : IDisposable
  {

    public void Dispose()
    {
      Client.ClearAll();
    }

    public ClientTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=brendan_hellar_test;";
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Testing";
      Client newClient = new Client(description);

      string result = newClient.GetDescription();

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Testing";
      Client newClient = new Client(description);

      string updatedDescription = "Updated Testing";
      newClient.SetDescription(updatedDescription);
      string result = newClient.GetDescription();

      Assert.AreEqual(updatedDescription, result);
    }
  }
}
