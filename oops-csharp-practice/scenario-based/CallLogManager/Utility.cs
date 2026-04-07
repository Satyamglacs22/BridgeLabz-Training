using System;
using System.Collections.Generic;
using System.Text;

namespace CallLogManager
{
    public class Utility
    {
        public static void Main()
        {
            CallLogManager manager = new CallLogManager();
            Console.WriteLine("Enter No of Call Logs");
            int n = int.Parse(Console.ReadLine());
            CallLog[] logs = new CallLog[n]; 

            // user input for the CallLog

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter Call Log Details for User {i+1}");
                logs[i] = new CallLog();
                manager.AddCallLog(logs[i]);
            }
            Console.WriteLine("--------------------CAll Log Details---------------------------");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine($"Details of User {j + 1} is :");
                logs[j].Display();
            }
            Console.Write("\nEnter keyword to search: ");
            string keyword = Console.ReadLine();
            manager.SearchByKeyword(logs, keyword);

            Console.WriteLine("-------------Filter By Time------------------");
            // Filter by time
            Console.Write("\nEnter start date (yyyy-mm-dd): ");
            DateTime startTime = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter end date (yyyy-mm-dd): ");
            DateTime endTime = DateTime.Parse(Console.ReadLine());

            manager.FilterByTime(logs, startTime, endTime);

        }
    }
}
