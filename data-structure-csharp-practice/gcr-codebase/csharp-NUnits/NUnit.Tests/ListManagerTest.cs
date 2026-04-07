using NUnit.Framework;
using ClassLibrary;
using System.Collections.Generic;

namespace NUnit.Tests
{
    [TestFixture]
    public class ListManagerTests
    {
        ListManager m;
        List<int> list;

        [SetUp]
        public void Setup()
        {
            m = new ListManager();
            list = new List<int>();
        }

        [Test]
        public void Add_Test()
        {
            m.AddElement(list, 10);
            Assert.AreEqual(1, m.GetSize(list));
        }

        [Test]
        public void Remove_Test()
        {
            list.Add(5);
            m.RemoveElement(list, 5);
            Assert.AreEqual(0, m.GetSize(list));
        }
    }
}
