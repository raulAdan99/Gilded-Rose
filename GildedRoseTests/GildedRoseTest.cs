using System.Collections.Generic;
using GildedRose.Application;
using GildedRose.Domain.Entities;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Test]
    public void Foo()
    {
        var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
        var app = new GildedRoseService(items);
        app.UpdateQuality();
        Assert.That(items[0].Name, Is.EqualTo("fixme"));
    }
}