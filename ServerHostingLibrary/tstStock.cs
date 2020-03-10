using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerHostingLibrary;

namespace ServerHostingTesting
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AvailableStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AvailableStock);
        }

        [TestMethod]
        public void ActiveOK()
        {
            //create an instance of the class we want to create
            clsStock AvailableStock = new clsStock();
            //create some test data to assign to the Server
            Boolean TestData = true;
            //assign the data to the Server
            AvailableStock.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AvailableStock.Active, TestData);
        }

        [TestMethod]
        public void DateAdded()
        {
            //create an instance of the class we want to create
            clsStock AvailableStock = new clsStock();
            //create some test data to assign to the Server
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the Server
            AvailableStock.ServerDateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AvailableStock.ServerDateAdded, TestData);
        }

        [TestMethod]
        public void ServerNo()
        {
            //create an instance of the class we want to create
            clsStock AvailableStock = new clsStock();
            //create some test data to assign to the Server
            Int32 TestData = 1;
            //assign the data to the Server
            AvailableStock.ServerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AvailableStock.ServerNo, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AvailableSock = new clsStock();
            //boolean variable o store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ServerNo = 1;
            //invoke the method
            Found = AvailableSock.Find(ServerNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
    }
}
