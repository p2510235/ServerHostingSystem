
namespace Test_Framework
{
    [TestClass]
    public class clsOrderProcessing
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of orderProcessing class
            clssOrderProcessing AnOrderProcessing = new clssOrderProcessing();
            //test to see that it exists
            Assert.IsNotNull(AnOrderProcessing);
        }
    }
}
