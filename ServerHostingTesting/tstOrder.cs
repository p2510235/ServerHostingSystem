﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerHostingLibrary;

namespace ServerHostingTesting
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void AddressNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnAddress = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.OrderNo= TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.OrderNo, TestData);
        }

    }
}
