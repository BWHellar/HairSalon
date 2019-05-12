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
    public void Stylist_InstanceOfStylist_Stylist()
    {
      string name = "Some Guy";
      Stylist stylist = new Stylist(name);
      Assert.AreEqual(typeof(Stylist), stylist.GetType());
    }

    [TestMethod]
    public void Equals_ReturnsTrueIfNameSame_Stylist()
    {
      Stylist stylistOne = new Stylist("Bobo", 1);
      Stylist stylistTwo = new Stylist("Bobo", 1);
      Assert.AreEqual(stylistOne, stylistTwo);
    }

    [TestMethod]
    public void Save_SavesToDatabase_Stylist()
    {
      Stylist stylist = new Stylist ("Bobo");
      stylist.Save();
      List<Stylist> result = Stylist.GetStylist();
      List<Stylist> list = new List<Stylist>{stylist};
      CollectionAssert.AreEqual(list, result);
    }
  }
}
