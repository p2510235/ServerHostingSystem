using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerHostingTesting;

namespace Test_Framework
{
    [TestClass]
    public class clsCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);

        }
        [TestMethod]
        public void DateAddedOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
        }
        public void PasswordOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "Samj1046";
            AnCustomer.Password = TestData;
            Assert.AreEqual(AnCustomer.Password, TestData);

        }
    }
}

