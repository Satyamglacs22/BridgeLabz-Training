using System;
using System.Collections.Generic;
using System.Text;

namespace CallLogManager
{
    public class CallLog
    {
        public string PhoneNumber;
        public string Message;
        public DateTime TimeStamp;

        public void Display()
        {
            Console.WriteLine($"PhoneNumber is : {PhoneNumber}");
            Console.WriteLine($"Message is : {Message}");
            Console.WriteLine($"Time Stamp is : {TimeStamp}");

            Console.WriteLine("---------------------------------------------------");
        }

    }
}
