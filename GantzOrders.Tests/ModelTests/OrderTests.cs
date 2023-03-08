using Microsoft.VisualStudio.TestTools.UnitTesting;
using GantzOrders.Models;
using System.Collections.Generic;
using System;

namespace GantzOrders.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesOrder_Order()
    {
      Order newOrder = new Order("Gantz Cheese Market", "22 wheels of cheddar", "October 1", 422 );
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDetails_ReturnsDetails_String()
    {
      string details = "22 wheels of cheddar";
      string title = "Gantz cheddar";
      string date = "October 1";
      decimal price = 422;
      Order newOrder = new Order(title, details, date, price);
      string result1 = newOrder.Details;
      string result2 = newOrder.Title;
      string result3 = newOrder.Date;
      decimal result4 = newOrder.Price;
      Assert.AreEqual(details, result1);
      Assert.AreEqual(title, result2);
      Assert.AreEqual(date, result3);
      Assert.AreEqual(price, result4);
    }

    [TestMethod]
    public void SetDetails_SetDetails_String()
    {
      string details = "22 wheels of cheddar";
      string title = "Gantz cheddar";
      string date = "October 1";
      decimal price = 422;
      Order newOrder = new Order(title, details, date, price);
      string updatedDetails = "33 lbs of Gouda ";
      newOrder.Details = updatedDetails;
      string result = newOrder.Details;
      Assert.AreEqual(updatedDetails, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string details1 = "22 wheels of cheddar";
      string title1 = "Gantz cheddar";
      string date1 = "October 1";
      decimal price1 = 422.00m;
      string details2 = "2 lbs sugar";
      string title2 = "Sweets by Mitch";
      string date2 = "April 4";
      decimal price2 = 10.22M;
      Order newOrder1 = new Order(title1, details1, date1, price1);
      Order newOrder2 = new Order(title2, details2, date2, price2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_SetsIdAndReturns_Int()
    {
      string details = "22 Wheels of cheddar";
      string title = "Gantz cheddar";
      string date = "October 1";
      decimal price = 422.22M;
      Order newOrder = new Order(title, details, date, price);
      int result = newOrder.Id;
      Assert.AreEqual(0, result);
      }
  }
}