using NUnit.Framework;
using System.Collections.Generic;
using WebApplicationTest;

namespace ConsoleApp.Classes
{
    [TestFixture]
    class UnitTest
    {
        [Test]
        public void TestRequest()
        {
            // Arrange
            CAPEXManager manager = new CAPEXManager();
            List<int> list = new List<int>();
            list.Add(1);

            // Act
            var str = manager.DoSomething();

            // Assert
            Assert.IsFalse(str == "I'm a requestor!", "String is not equal");
            Assert.Contains(2, list);
        }
    }
}
