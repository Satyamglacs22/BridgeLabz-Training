using NUnit.Framework;
using ClassLibrary;

namespace NUnit.Tests
{
    [TestFixture]
    public class MathUtilsTests
    {
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(6)]
        public void Even_Numbers_Should_Return_True(int num)
        {
            Assert.IsTrue(new MathUtils().IsEven(num));
        }

        [TestCase(7)]
        [TestCase(9)]
        public void Odd_Numbers_Should_Return_False(int num)
        {
            Assert.IsFalse(new MathUtils().IsEven(num));
        }
    }
}
