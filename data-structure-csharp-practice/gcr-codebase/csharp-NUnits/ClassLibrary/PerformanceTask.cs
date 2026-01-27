using System.Threading;

namespace ClassLibrary
{
    public class PerformanceTask
    {
        public void LongRunningTask()
        {
            Thread.Sleep(3000); // 3 seconds
        }
    }
}
