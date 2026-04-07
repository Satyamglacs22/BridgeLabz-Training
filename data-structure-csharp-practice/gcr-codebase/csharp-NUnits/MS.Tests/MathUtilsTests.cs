using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace MS.Tests
{
    [TestClass]
    public class MathUtilsTests
    {
        [DataTestMethod]
        [DataRow(2)]
        [DataRow(4)]
        [DataRow(6)]
        public void Even_Numbers_Should_Return_True(int num)
        {
            Assert.IsTrue(new MathUtils().IsEven(num));
        }

        [DataTestMethod]
        [DataRow(7)]
        [DataRow(9)]
        public void Odd_Numbers_Should_Return_False(int num)
        {
            Assert.IsFalse(new MathUtils().IsEven(num));
        }
    }
}
