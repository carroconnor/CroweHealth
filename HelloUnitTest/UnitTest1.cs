using CroweHealth;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestActual()
        {
            // Arrange
            HelloWorld hw = new HelloWorld();
            string hello = "Hello World";

            // Act
            string actual = hw.CreateHelloWorld(hello);

            //Assert
            Assert.AreEqual(hello, actual);
        }
    }
}
