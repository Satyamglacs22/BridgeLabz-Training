using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace MS.Tests
{
    [TestClass]
    public class ListManagerTests
    {
        ListManager m;
        List<int> list;

        [TestInitialize]
        public void Setup()
        {
            m = new ListManager();
            list = new List<int>();
        }

        [TestMethod]
        public void Add_Test()
        {
            m.AddElement(list, 10);
            Assert.AreEqual(1, m.GetSize(list));
        }

        [TestMethod]
        public void Remove_Test()
        {
            list.Add(5);
            m.RemoveElement(list, 5);
            Assert.AreEqual(0, m.GetSize(list));
        }
    }
}
