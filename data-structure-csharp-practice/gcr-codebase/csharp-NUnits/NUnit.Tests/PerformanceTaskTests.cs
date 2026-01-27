using NUnit.Framework;
using ClassLibrary;

namespace NUnit.Tests
{
    [TestFixture]
    public class PerformanceTaskTests
    {
        [Test]
        [Timeout(2000)]
        public void Task_Should_Complete_Under_2_Seconds()
        {
            new PerformanceTask().LongRunningTask();
        }
    }
}
