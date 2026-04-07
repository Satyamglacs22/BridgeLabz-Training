using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Library_ManageMent_System
{
    public class Book : LibraryItem, IReservable
    {
        private bool isAvailable = true;

        public override int GetLoanDuration()
        {
            return 14; // 14 days
        }

        public void ReserveItem()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine("Book reserved successfully");
            }
            else
            {
                Console.WriteLine("Book not available");
            }
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }
    }


}
