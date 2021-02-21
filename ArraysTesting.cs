using Microsoft.VisualStudio.TestTools.UnitTesting;
using Arrays;
using System.Linq;

namespace ArraysTest
{
    [TestClass]
    public class ArraysTesting
    {
        [TestMethod]
        public void TastArrayA()
        {
            int[] arrayA = { 4, 5, 8, 3, 4 };
            int[] sortedArrayA = { 3, 4, 4, 5, 8};

            Assert.IsTrue(sortedArrayA.SequenceEqual(ArrayClass.Sorted(arrayA)));
        }
    }
}
