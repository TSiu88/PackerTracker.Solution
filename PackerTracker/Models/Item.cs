using System;
using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string Name { get; set; }
    public bool Bought { get; set; }
    public bool Packed { get; set; }
    public int Price { get; set; }

    public int Id { get; }
    private static List<Item> _instances = new List<Item>() {};
    public Item(string name, bool bought, bool packed, int price)
    {
      Name = name;
      Bought = bought;
      Packed = packed;
      Price = Convert.ToInt32(price);
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int id)
    {
      return _instances[id-1];
    }
  }
}