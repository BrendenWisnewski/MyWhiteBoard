using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckVowels;

namespace TestVowels
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVowels_Brenden()
        {
            Assert.AreEqual(2, Vowels.HowManyVowels("Brenden"));
        }
        [TestMethod]
        public void TestVowels_sentence()
        {
            Assert.AreEqual(5, Vowels.HowManyVowels("The brown dog eats"));
        }
        [TestMethod]
        public void TestVowels_UPERCASE()
        {
            Assert.AreEqual(3, Vowels.HowManyVowels("EMANI"));
        }
        [TestMethod]
        public void TestVowels_SpecialCharacters()
        {
            Assert.AreEqual(4, Vowels.HowManyVowels("#$%^&%aeinmhdf&*(i"));
        }
        [TestMethod]
        public void TestVowels_EmptyString()
        {
            Assert.AreEqual(0, Vowels.HowManyVowels(" "));
        }

    }
}
