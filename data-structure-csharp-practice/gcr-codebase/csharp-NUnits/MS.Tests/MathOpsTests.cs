using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace MS.Tests
{
    [TestClass]
    public class MathOpsTests
    {
        [TestMethod]
        //[ExpectedException(typeof(ArithmeticException))]
        public void Divide_By_Zero_Should_Throw_Exception()
        {
            MathOps ops = new MathOps();
            ops.Divide(10, 0);
        }
    }
}
