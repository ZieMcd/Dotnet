using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testability;

namespace Testabilty.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IceBreaker()
        {
            var calculator =  new Testability.Calculator();
            var sum = calculator.Add(1,1);

            Assert.AreEqual(3,sum);
        }
    }
}
