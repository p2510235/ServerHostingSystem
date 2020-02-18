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
    }
}
