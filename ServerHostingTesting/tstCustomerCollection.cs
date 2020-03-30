using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerHostingLibrary;
using ServerHostingTesting;

namespace ServerHostingTesting
{
    
    [TestClass]
  
    
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }
        public void NameListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<ClsCustomer>();
        clsCustomer TestItem = new clsCustomer();
        TestItem.Active = true;
        TestItem.CustomerNo = 1;
        TestItem.Name = "Sam";
        TestItem.DateAdded = DateTime.Now.Date;
        TestItem.PhoneNumber = "07946274531";
        TestItem.PostCode = "Ng31 8RL";

        TestList.Add(TestItem);
        AllCustomers.CustomerList = TestList;
        Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }
    }

