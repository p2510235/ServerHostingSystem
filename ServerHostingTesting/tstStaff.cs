using System;
using ServerHostingLibrary;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServerHostingTesting
{

    [TestClass]
    public class tstStaff
    {

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
            clsStaff AStaff= new clsStaff();
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
            if (AStaff.StaffDOB != new DateTime(1998,11,14))
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

        }

       

    
}

