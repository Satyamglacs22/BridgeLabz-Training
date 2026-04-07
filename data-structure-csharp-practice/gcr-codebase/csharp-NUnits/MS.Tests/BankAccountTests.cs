using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace MS.Tests
{
    [TestClass]
    public class BankAccountTests
    {
        BankAccount acc;

        [TestInitialize]
        public void Setup()
        {
            acc = new BankAccount();
        }

        [TestMethod]
        public void Deposit_Test()
        {
            acc.Deposit(1000);
            Assert.AreEqual(1000, acc.GetBalance());
        }

        [TestMethod]
        public void Withdraw_Test()
        {
            acc.Deposit(1000);
            acc.Withdraw(500);
            Assert.AreEqual(500, acc.GetBalance());
        }

        [TestMethod]
        //[ExpectedException(typeof(InvalidOperationException))]
        public void Withdraw_Insufficient_Funds_Test()
        {
            acc.Withdraw(100);
        }
    }
}
