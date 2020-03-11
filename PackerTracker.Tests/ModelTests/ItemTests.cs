using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ItemTests
  {
    // Test methods go here
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("name",true,true, 1);
      string resultName = newItem.Name;
      bool resultBought = newItem.Bought;
      bool resultPacked = newItem.Packed;
      int resultPrice = newItem.Price;
      Assert.AreEqual(resultName, "name");
      Assert.AreEqual(resultBought, true);
      Assert.AreEqual(resultPacked, true);
      Assert.AreEqual(resultPrice, 1);
    }

  }
}