using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewCamelCase;

namespace NewTestCamelCase
{
    [TestClass]
    public class CasingTests
    {
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void TestMethod_theCatInTheHat()
            {
                Assert.AreEqual("theCatInTheHat", Casing.CamelCase("The     Cat      In The Hat"));
            }
            [TestMethod]
            public void TestMethod_TheCatInTheHat()
            {
                Assert.AreEqual("TheCatInTheHat", Casing.PascalCase("The Cat In The Hat"));
            }

        }
    }
}
