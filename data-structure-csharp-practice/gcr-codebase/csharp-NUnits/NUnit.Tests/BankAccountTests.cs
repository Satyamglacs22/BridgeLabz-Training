using NUnit.Framework;
using ClassLibrary;

namespace NUnit.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        BankAccount acc;

        [SetUp]
        public void Setup()
        {
            acc = new BankAccount();
        }

        [Test]
        public void Deposit_Test()
        {
            acc.Deposit(1000);
            Assert.AreEqual(1000, acc.GetBalance());
        }

        [Test]
        public void Withdraw_Test()
        {
            acc.Deposit(1000);
            acc.Withdraw(500);
            Assert.AreEqual(500, acc.GetBalance());
        }

        [Test]
        public void Withdraw_Insufficient_Funds_Test()
        {
            Assert.Throws<InvalidOperationException>(() => acc.Withdraw(100));
        }
    }
}
