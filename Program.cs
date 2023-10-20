// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System;
using System.Linq;

class MyItem {
    public int id { get; set; }
}


class Program {
  public static void Main (string[] args) {


    List<MyItem> myList = new List<MyItem>
    {
        new MyItem { id = 2 },
        new MyItem { id = 2 },
        new MyItem { id = 2 },
        new MyItem { id = 4 },
        new MyItem { id = 4 },
        new MyItem { id = 4 },
        new MyItem { id = 6 },
        new MyItem { id = 6 }
    };

    int targetValue = 4;

    int firstOccurrenceIndex = myList
        .Select((value, index) => new { Value = value, Index = index })
        .Where(item => item.Value.id == targetValue)
        .Select(item => item.Index)
        .FirstOrDefault();
    
    // 等同於 myList.FindIndex(x => x.id == targetValue);
    if (firstOccurrenceIndex != -1)
    {
        Console.WriteLine($"id={targetValue} 第一次出現的索引值是 {firstOccurrenceIndex}。");
    }
    else
    {
        Console.WriteLine($"id={targetValue} 未在列表中找到。");
    }

    
}}