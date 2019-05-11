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
    public void SavesToDataBase_Stylist()
    {
      Stylist stylist = new Stylist("Test");
      stylist.Save();

      List<Stylist> result = Stylist.GetStylist();

      Assert.AreEqual(1, result.Count);
    }
  }
}
