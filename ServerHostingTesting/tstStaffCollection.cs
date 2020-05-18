using System;
using System.Collections.Generic;
using System.Linq;
using ServerHostingLibrary;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServerHostingTesting
{
    [TestClass]
    public class tstStaffCollection
    {
        public List<clsStaff> StaffList;

        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.EmploymentStatus = true;
            TestItem.StaffNo = 1;
            TestItem.StaffName = "Joe Bloggs";
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffDOB = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }



        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.EmploymentStatus = true;
            TestStaff.StaffNo = 1;
            TestStaff.StaffStartDate = DateTime.Now.Date;
            TestStaff.StaffName = "Joe Bloggs";
            TestStaff.StaffRole = "Manager";
            TestStaff.StaffDOB = DateTime.Now.Date;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.EmploymentStatus = true;
            TestItem.StaffNo = 1;
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffName = "Joe Bloggs";
            TestItem.StaffRole = "Manager";
            TestItem.StaffDOB = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }




        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.EmploymentStatus = true;
            TestItem.StaffNo = 1;
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffName = "Joe Bloggs";
            TestItem.StaffRole = "Manager";
            TestItem.StaffDOB = DateTime.Now.Date;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.EmploymentStatus = true;
            TestItem.StaffNo = 1;
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffName = "Joe Bloggs";
            TestItem.StaffRole = "Manager";
            TestItem.StaffDOB = DateTime.Now.Date;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record   
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.EmploymentStatus = true;
            TestItem.StaffNo = 1;
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffName = "Joe Bloggs";
            TestItem.StaffRole = "Manager";
            TestItem.StaffDOB = DateTime.Now.Date;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //modify the test data
            TestItem.EmploymentStatus = false;
            TestItem.StaffNo = 9;
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffName = "Joe News";
            TestItem.StaffRole = "CEO";
            TestItem.StaffDOB = DateTime.Now.Date;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

    }
}
