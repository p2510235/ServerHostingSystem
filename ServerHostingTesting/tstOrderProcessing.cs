using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerHostingTesting;

namespace Test_Framework
{
    [TestClass]
    public class clsOrderProcessing
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of orderProcessing class
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            //test to see that it exists
            Assert.IsNotNull(AnOrderProcessing);
        }
        [TestMethod]
        public void orderNumberOK()
        {
            //create an instance of orderProcessing class
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            int orderNumber = 12345;
            AnOrderProcessing.orderNumber = TestData;
            //test to see that it exists
            Assert.AreEqual(AnOrderProcessing.orderNumber, TestData);
        }
        [TestMethod]
        public void CustomerIdOK()
        {
            //create an instance of orderProcessing class
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            int TestData = 00;
            AnOrderProcessing.customerId = TestData;
            Assert.AreEqual(AnOrderProcessing.customerId, TestData);
        }
        [TestMethod]
        public void OrderDateOK()
        {
            //create an instance of orderProcessing class
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            DateTime TestData = DateTime.Now.Date;
            AnOrderProcessing.OrderDate = TestData;
            Assert.AreEqual(AnOrderProcessing.OrderDate, TestData);
        }
        [TestMethod]
        public void OrderDetailsOK()
        {
            //create an instance of orderProcessing class
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            String TestData = "Game Server Package 1";
            AnOrderProcessing.OrderDetails = TestData;
            Assert.AreEqual(AnOrderProcessing.OrderDetails, TestData);
        }
        [TestMethod]
        public void DispatchedOK()
        {
            //create an instance of orderProcessing class
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            Boolean dispatchedTrue = true;
            Boolean dispatchedFalse = false;
            int CustomerId = 00;
            if (AnOrderProcessing.Dispatched == true)
                return true;
            else
            {
                false;
            }
            Assert.IsTrue(dispatchedTrue);
        }
        [TestMethod]
        public void TotalPriceOK()
        {
            //create an instance of orderProcessing class
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            int TestData = 100.00;
            AnOrderProcessing.TotalPrice = TestData;
            // test to ensure the value is the same and correct
            Assert.AreEqual(AnOrderProcessing.TotalPrice, TestData);
        }
        [TestMethod]
        public void TestFindOrder()
        {
            //create an instance of orderProcessing class
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            Boolean True = true;
            Boolean False = false;
            int orderNo = 12345;
            Found = AnOrderProcessing.Find(orderNumber);
            if (AnOrderProcessing.orderNumber != orderNo)
                return false;
            else
            {
                true;
            }
            Assert.IsTrue(orderNumber);
        }
        [TestMethod]
        public void QuantityOK()
        {
            //create an instance of orderProcessing class
            clsOrderProcessing AnOrderProcessing = new clsOrderProcessing();
            int TestData = 1;
            AnOrderProcessing.Quantity = TestData;
            Assert.AreEqual(AnOrderProcessing.Quantity, TestData);
        }




    }
}


