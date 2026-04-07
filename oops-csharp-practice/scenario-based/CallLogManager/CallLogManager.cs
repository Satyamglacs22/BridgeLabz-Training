using System;
using System.Collections.Generic;
using System.Text;

namespace CallLogManager
{
    public class CallLogManager
    {
        public void AddCallLog(CallLog log)
        {
            Console.WriteLine("Enter Phone Number");
            log.PhoneNumber = Console.ReadLine();


            Console.WriteLine("Enter Name");
            log.Message = Console.ReadLine();

            Console.WriteLine("Time Stamp");
            log.TimeStamp = DateTime.Now;
        }
        public void SearchByKeyword(CallLog[] logs, string keyword)
        {
            Console.WriteLine("\nLogs containing keyword: " + keyword);

            for (int i = 0; i < logs.Length; i++)
            {
                if (logs[i] != null && logs[i].Message.Contains(keyword))
                {
                    logs[i].Display();
                }
            }
        }
        public void FilterByTime(CallLog[] logs, DateTime start, DateTime end)
        {
            Console.WriteLine("\nLogs in given time range:");

            for (int i = 0; i < logs.Length; i++)
            {
                if (logs[i] != null &&
                    logs[i].TimeStamp >= start &&
                    logs[i].TimeStamp <= end)
                {
                    logs[i].Display();
                }
            }
        }


    }
}
