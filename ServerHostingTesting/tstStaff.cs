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
            clsStaff AStaff = new clsStaff();
            //this is to test that it exists
            Assert.IsNotNull(AStaff);

        }

        [TestMethod]
        public void StaffNoExists()
        {
            clsStaff AStaff = new clsStaff();

        }
    }
}
