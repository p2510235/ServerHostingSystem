using System;
using ServerHostingLibrary;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServerHostingTesting
{

    [TestClass]
    public class tstStaff
    {

        //good test data
        //create some test data to pass to the method
        string StaffNo = "1";
        string StaffDOB = "14/11/1998";
        string StaffStartDate = DateTime.Now.Date.ToString();
        string StaffRole = "Manager";
        string StaffName = "Joe Bloggs";

        [TestMethod]
        public void InstanceOK()
        {
            //Created an instance of staff
            clsStaff AStaff = new clsStaff();
            //this is to test that it exists
            Assert.IsNotNull(AStaff);

        }

        [TestMethod]
        public void EmploymentStatusOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.EmploymentStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.EmploymentStatus, TestData);
        }

        [TestMethod]
        public void StaffStartDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.StaffStartDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffStartDate, TestData);
        }


        [TestMethod]
        public void StaffNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AStaff.StaffNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffNo, TestData);
        }

        [TestMethod]
        public void StaffDOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = new DateTime(1998, 11, 14);
            //assign the data to the property
            AStaff.StaffDOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffDOB, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "John Doe";
            //assign the data to the property
            AStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffName, TestData);
        }

        [TestMethod]
        public void StaffRolePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Manager";
            //assign the data to the property
            AStaff.StaffRole = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffRole, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method
            int StaffNo = 1; ;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the resut of the searh
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            int StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the staff name
            if (AStaff.StaffNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestStaffStartDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test dat to use with the method
            int StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.StaffStartDate != Convert.ToDateTime("20/01/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            int StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.StaffName != "Joe Bloggs")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        public void TestStaffDOBFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test dat to use with the method
            int StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.StaffDOB != new DateTime(1998, 11, 14))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestStaffRoleFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test dat to use with the method
            int StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.StaffRole != "Manager")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestEmploymentStatusFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test dat to use with the method
            int StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the property
            if (AStaff.EmploymentStatus != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(StaffNo, StaffName, StaffDOB, StaffRole, StaffStartDate);
            Assert.AreEqual(Error, "");

        }

        public void StaffNoMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string StaffNo = "";
            Error = AStaff.Valid(StaffNo, StaffName, StaffDOB, StaffRole, StaffStartDate);
            Assert.AreNotEqual(Error, "");

        }

        public void StaffNoMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string StaffNo = "a";
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNoMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string StaffNo = "aa";
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffNo = "aaaaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNoMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffNo = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNoMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffNo = "aaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffNo = "";
            StaffNo = StaffNo.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        public void StaffRoleMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string StaffRole = "";
            Error = AStaff.Valid(StaffNo, StaffName, StaffDOB, StaffRole, StaffStartDate);
            Assert.AreNotEqual(Error, "");

        }

        public void StaffRoleMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string StaffRole = "a";
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string StaffRole = "aa";
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = "aaaaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = "aaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffRoleExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }





        public void StaffDOBMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-101);
            string DateAdded = TestDate.ToString();
            Error = AStaff.Valid(StaffNo, StaffName, StaffDOB, StaffRole, StaffStartDate);
            Assert.AreNotEqual(Error, "");

        }

        public void StaffDOBMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-99);
            string DateAdded = TestDate.ToString();
            Error = AStaff.Valid(StaffNo, StaffName, StaffDOB, StaffRole, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = AStaff.Valid(StaffNo, StaffName, StaffDOB, StaffRole, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = AStaff.Valid(StaffNo, StaffName, StaffDOB, StaffRole, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }


        

        [TestMethod]
        public void StaffDOBExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffDOB = "";
            StaffNo = StaffDOB.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }








        public void StaffNameMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            Error = AStaff.Valid(StaffNo, StaffName, StaffDOB, StaffRole, StaffStartDate);
            Assert.AreNotEqual(Error, "");

        }

        public void StaffNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string StaffName = "a";
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string StaffName = "aa";
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aaaaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "aaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void StaffNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "";
            StaffNo = StaffName.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }




        public void StaffStartDateMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = AStaff.Valid(StaffNo, StaffName, StaffDOB, StaffRole, StaffStartDate);
            Assert.AreNotEqual(Error, "");

        }

        public void StaffStartDateMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = AStaff.Valid(StaffNo, StaffName, StaffDOB, StaffRole, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartDateMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            Error = AStaff.Valid(StaffNo, StaffName, StaffDOB, StaffRole, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }





        [TestMethod]
        public void StaffStartDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = AStaff.Valid(StaffNo, StaffName, StaffDOB, StaffRole, StaffStartDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffStartDateExtremeMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string StaffStartDate = TestDate.ToString();
            Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartDateInvalidData()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string StaffStartDate = "this is not a date";
            Error = AStaff.Valid(StaffNo, StaffName, StaffDOB, StaffRole, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }


    }


}


