using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerHostingTesting;

namespace Test_Framework
{
    [TestClass]
    public class clsCustomer
    {
        string Name = "Sam";
        string PhoneNumber = "07946274531";
        string DateAdded = DateTime.Now.Date.ToString();
        string PostCode = "Ng31 8RL";
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
        [TestMethod]
        public void FindMethod()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            Boolean found = false;
            Int32 CustomerNo = 1;
            Found = AnCustomer.Find(CustomerNo);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = AnCustomer.Find(CustomerNo);
            if (AnCustomer.CustomerNo != 21)
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = AnCustomer.Find(CustomerNo);
            if (AnCustomer.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneAddedFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = AnCustomer.Find(CustomerNo);
            if (AnCustomer.PhoneNumber != "07946274531")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = AnCustomer.Find(CustomerNo);
            if (AnCustomer.Name != "Sam")
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = AnCustomer.Find(CustomerNo);
            if (AnCustomer.Name != "NG31 8RL")
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }

        public void TestOwnServerFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = AnCustomer.Find(AddressNo);
            //check the property
            if (AnCustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void ValidMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Error = AnCustomer.Valid(CusomterNo, DateAdded, Name, PostCode, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
    }
}
