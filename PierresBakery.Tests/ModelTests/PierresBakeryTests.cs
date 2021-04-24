using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
    [TestClass]
    public class PierresBakeryTests : IDisposable
    {

        public void Dispose()
        {
            // Item.ClearAll();
        }

        [TestMethod]
        public void BreadConstructor_CreateInstanceOfBread_Bread()
        {
            Bread newBread = new Bread(5);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void OrderedQuantity_OrderedBreadQuantiry_Int()
        {
            int orderedQuantity = 5;
            Bread newBread = new Bread(orderedQuantity);
            Assert.AreEqual(orderedQuantity, newBread.OrderedQuantity);
        }

        [TestMethod]
        public void FindTotalQuantity_CalculatedBreadQuantity_Int()
        {
            int orderedQty = 14;
            Bread newBread = new Bread(orderedQty);
            int totalQty = newBread.FindTotalQuantity();
            Assert.AreEqual(21, totalQty);
        }

        // // // [TestMethod]
        // // // public void GenNumerals_GeneratedADictionaryWithKVPair_Dictionary()
        // // // {
        // // //     //Arrange
        // // //     // GenNumber(userenterednumber)
        // // //     int userEnteredNum = 100;
        // // //     PrimeNum primeObject = new PrimeNum();

        // // //     //Act
        // // //     Dictionary<int, string> allNumbers = new Dictionary<int, string>() { };
        // // //     for (int i = 2; i <= userEnteredNum; i++)
        // // //     {
        // // //         allNumbers[i] = "unProcessed";
        // // //     }
        // // //     Dictionary<int, string> result = primeObject.GenNumber(userEnteredNum);

        // // //     //Assert
        // // //     CollectionAssert.AreEqual(allNumbers, result);
        // // // }

        // // // [TestMethod]
        // // // public void SetDescription_SetDescription_String()
        // // // {
        // // //     //Arrange
        // // //     string description = "Walk the dog2.";
        // // //     Item newItem = new Item(description);

        // // //     //Act
        // // //     string updatedDescription = "Do the dishes";
        // // //     newItem.Description = updatedDescription;
        // // //     string result = newItem.Description;

        // // //     //Assert
        // // //     Assert.AreEqual(updatedDescription, result);
        // // // }

        // // // [TestMethod]
        // // // public void GetAll_ReturnsEmptyList_ItemList()
        // // // {
        // // //     // Arrange
        // // //     List<Item> newList = new List<Item> { };

        // // //     // Act
        // // //     List<Item> result = Item.GetAll();

        // // //     foreach (Item thisItem in result)
        // // //     {
        // // //         Console.WriteLine("Output from empty list GetAll test: " + thisItem.Description);
        // // //     }
        // // //     // Assert
        // // //     CollectionAssert.AreEqual(newList, result);
        // // // }

        // // // [TestMethod]
        // // // public void GetAll_ReturnsItems_ItemList()
        // // // {
        // // //     //Arrange
        // // //     string description01 = "Walk the dog3";
        // // //     string description02 = "Wash the dishes";
        // // //     Item newItem1 = new Item(description01);
        // // //     Item newItem2 = new Item(description02);
        // // //     List<Item> newList = new List<Item> { newItem1, newItem2 };

        // // //     //Act
        // // //     List<Item> result = Item.GetAll();

        // // //     foreach (Item thisItem in result)
        // // //     {
        // // //         Console.WriteLine("Output from second GetAll test: " + thisItem.Description);
        // // //     }

        // // //     //Assert
        // // //     CollectionAssert.AreEqual(newList, result);
        // // // }
    }
}