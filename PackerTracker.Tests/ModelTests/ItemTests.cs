using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }
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


    [TestMethod]
    public void GetAll_ReturnsAllItemsInItemList_Item1()
    {
      Item newItem1 = new Item("item1", true, false, 2);
      Item newItem2 = new Item("item2", true, true, 4);
      CollectionAssert.Contains(Item.GetAll(), newItem1);
    }

    [TestMethod]
    public void ClearAll_DeletesAllItemsInItemList_EmptyList()
    {
      Item newItem1 = new Item("item1", true, false, 2);
      Item newItem2 = new Item("item2", true, true, 4);
      Item.ClearAll();
      CollectionAssert.DoesNotContain(Item.GetAll(), newItem1);
    }

    [TestMethod]
    public void Find_FindsAndReturnsItemBtIDNumber_Item()
    {
      Item newItem1 = new Item("item1", true, false, 2);
      Item newItem2 = new Item("item2", true, true, 4);
      Item foundItem = Item.Find(2);
      Assert.AreEqual(foundItem, newItem2);
    }
  }
}