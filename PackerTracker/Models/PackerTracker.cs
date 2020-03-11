using System;
using System.Collections.Generic;

namespace ProjectName.Models
{
  public class Item
  {
    public string Property { get; set; }
    private static List<Item> _instances = new List<Item>() {};
    public Item(string property)
    {
      Property = property;
      _instances.Add(this);
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}