using System;
using ServerHostingTesting;
using ServerHOstingLibrary;
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
            AStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Active, TestData);
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
            Int32 TestData = 1;
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
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffDOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffDOB, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
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

        

        
    }
}
