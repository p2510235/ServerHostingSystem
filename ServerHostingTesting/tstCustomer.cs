using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerHostingTesting;
using ServerHostingLibrary;

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
            clsCustomer anCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(anCustomer);

        }
        [TestMethod]
        public void DateAddedOK()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            anCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anCustomer.DateAdded, TestData);
        }
        public void PasswordOK()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "Samj1046";
            anCustomer.Password = TestData;
            Assert.AreEqual(anCustomer.Password, TestData);

        }
        [TestMethod]
        public void FindMethod()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            Boolean found = false;
            Int32 CustomerNo = 1;
            Found = anCustomer.Find(CustomerNo);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = anCustomer.Find(CustomerNo);
            if (anCustomer.CustomerNo != 21)
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = anCustomer.Find(CustomerNo);
            if (anCustomer.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneAddedFound()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = anCustomer.Find(CustomerNo);
            if (anCustomer.PhoneNumber != "07946274531")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = anCustomer.Find(CustomerNo);
            if (anCustomer.Name != "Sam")
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 CustomerNo = 21;
            Found = anCustomer.Find(CustomerNo);
            if (anCustomer.Name != "NG31 8RL")
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }

        public void TestOwnServerFound()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = anCustomer.Find(AddressNo);
            //check the property
            if (anCustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void ValidMethodOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String Error = "";
            Error = anCustomer.Valid(CusomterNo, DateAdded, Name, PostCode, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        public string Valid(string Name,
          string phoneNumber,
          DateTime DateAdded,
          string postcode);

        public void NameNotNull()
        {
            clsCustomer anCustomer = new clsCustomer();
            String Error = "";
            String Name = "";
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        public void NameNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "a"; //this should be ok
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aa"; //this should be ok
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaa"; //this should be ok
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameNoMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaa"; //this should be ok
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameNoMid()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaa"; //this should be ok
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void DateTimeInvalid()
        {
            clsCustomer anCustomer = new clsCustomer();
            String Error = "";
            string DateAdded = "This is not a date!";
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            Assert.AreNotEqual(Error, "");
            try
            {
                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";

                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
        }
        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "";
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "a";
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aa";
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaa";
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaaa";
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "aaaaaaaaaa";
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaa";
            //invoke the method
            Error = anCustomer.Valid(Name, PhoneNumber, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}
