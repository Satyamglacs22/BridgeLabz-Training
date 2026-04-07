using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace MS.Tests
{
    [TestClass]
    public class DatabaseConnectionTests
    {
        private DatabaseConnection db;

        [TestInitialize]
        public void Setup()
        {
            db = new DatabaseConnection();
            db.Connect();
        }

        [TestCleanup]
        public void Cleanup()
        {
            db.Disconnect();
        }

        [TestMethod]
        public void Connection_Should_Be_Established()
        {
            Assert.IsTrue(db.IsConnected);
        }
    }
}
