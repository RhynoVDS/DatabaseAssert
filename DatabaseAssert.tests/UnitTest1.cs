using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabaseAssert.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AssertThat.Table("test").HasColumn("test").OfType("int");
        }
    }
}
