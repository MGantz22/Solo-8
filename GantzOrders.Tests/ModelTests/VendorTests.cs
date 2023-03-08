using Microsoft.VisualStudio.TestTools.UnitTesting;
using GantzOrders.Models;
using System.Collections.Generic;
using System;

namespace GantzOrders.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.clearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOf_Vendor()
    {
      Vendor newVendor = new Vendor("Gantz Cheese Market", "Largest cheese selection in the Midwest");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void CreatesNameAndDetails_String()
    {
      string name = "Gantz Cheese Market";
      string description = "Largest cheese selection in the Midwest";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      string result1 = newVendor.Description;
      Assert.AreEqual(name, result);
      Assert.AreEqual(description, result1);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Gantz Cheese Market";
      string description = "Largest cheese selection in the Midwest";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name1 = "Gantz Cheese Market";
      string description1 = "Largest cheese selection in the Midwest";
      string name2 = "Gman Coffee Co";
      string description2 = "Coffee bean roasters";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsVendor_Vendor()
    {
      string name1 = "Gantz Cheese Market";
      string description1 = "Largest cheese selection in the Midwest";
      string name2 = "Gman Coffee Co";
      string description2 = "Coffee bean roasters";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      Vendor result = Vendor.Find(1);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_PlaceOrderWithVendor_OrderList()
    {
      string name = "Gantz Cheese Market";
      string description = "Largest cheese selection in the Midwest";
      Vendor newVendor = new Vendor(name, description);
      string details = "22 wheels of cheddar";
      string title = "Gantz cheddar";
      string date = "October 1";
      decimal price = 422;
      Order newOrder = new Order(title, details, date, price);
      List<Order> newList = new List<Order> { newOrder };
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}