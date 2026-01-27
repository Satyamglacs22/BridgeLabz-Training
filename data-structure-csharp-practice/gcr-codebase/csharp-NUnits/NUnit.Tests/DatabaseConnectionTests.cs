using NUnit.Framework;
using ClassLibrary;

namespace NUnit.Tests
{
    [TestFixture]
    public class DatabaseConnectionTests
    {
        private DatabaseConnection db;

        [SetUp]
        public void Setup()
        {
            db = new DatabaseConnection();
            db.Connect();
        }

        [TearDown]
        public void TearDown()
        {
            db.Disconnect();
        }

        [Test]
        public void Connection_Should_Be_Established()
        {
            Assert.IsTrue(db.IsConnected);
        }
    }
}
