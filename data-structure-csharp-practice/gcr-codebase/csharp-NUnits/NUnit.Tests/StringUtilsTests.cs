using NUnit.Framework;
using ClassLibrary;

namespace NUnit.Tests
{
    [TestFixture]
    public class StringUtilsTests
    {
        StringUtils s;

        [SetUp]
        public void Setup()
        {
            s = new StringUtils();
        }

        [Test] public void Reverse_Test() => Assert.AreEqual("olleh", s.Reverse("hello"));
        [Test] public void Palindrome_Test() => Assert.IsTrue(s.IsPalindrome("madam"));
        [Test] public void Upper_Test() => Assert.AreEqual("HELLO", s.ToUpperCase("hello"));
    }
}
