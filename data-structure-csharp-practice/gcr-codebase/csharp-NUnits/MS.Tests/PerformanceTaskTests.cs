using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace MS.Tests
{
    [TestClass]
    public class PerformanceTaskTests
    {
        [TestMethod]
        [Timeout(2000)]
        public void Task_Should_Complete_Under_2_Seconds()
        {
            new PerformanceTask().LongRunningTask();
        }
    }
}
