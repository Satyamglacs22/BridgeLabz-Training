using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace MS.Tests
{
    [TestClass]
    public class StringUtilsTests
    {
        StringUtils s;

        [TestInitialize]
        public void Setup()
        {
            s = new StringUtils();
        }

        [TestMethod] public void Reverse_Test() => Assert.AreEqual("olleh", s.Reverse("hello"));
        [TestMethod] public void Palindrome_Test() => Assert.IsTrue(s.IsPalindrome("madam"));
        [TestMethod] public void Upper_Test() => Assert.AreEqual("HELLO", s.ToUpperCase("hello"));
    }
}
