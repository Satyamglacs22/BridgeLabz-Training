using NUnit.Framework;
using ClassLibrary;

namespace NUnit.Tests
{
    [TestFixture]
    public class MathOpsTests
    {
        [Test]
        public void Divide_By_Zero_Should_Throw_Exception()
        {
            MathOps ops = new MathOps();
            Assert.Throws<ArithmeticException>(() => ops.Divide(10, 0));
        }
    }
}
