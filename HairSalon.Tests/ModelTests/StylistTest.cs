using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;
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
        DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=dylan_crocker_test;";
    }

    [TestMethod]
    public void TrueOrFalse_ReturnsTrueIfStylistNameMatch_True()
    {
      Stylist stylist = new Stylist("Stylist", 5);
      Stylist stylist2 = new Stylist("Stylist", 5);

      Assert.AreEqual(stylist, stylist2);
    }
  }
}
