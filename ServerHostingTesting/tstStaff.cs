using System;
using ServerHostingTesting;
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
            clsStaff newStaff = new clsStaff();
            //this is to test that it exists
            Assert.IsNotNull(newStaff);

        }

        [TestMethod]
        public void StaffNoExists()
        {
            clsStaff newStaff = new clsStaff();

        }
    }
}
