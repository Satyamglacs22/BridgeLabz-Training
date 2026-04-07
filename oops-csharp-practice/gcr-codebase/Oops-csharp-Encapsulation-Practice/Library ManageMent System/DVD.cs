using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Library_ManageMent_System
{
    public class DVD : LibraryItem, IReservable
    {
        private bool isAvailable = true;

        public override int GetLoanDuration()
        {
            return 3; // 3 days
        }

        public void ReserveItem()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine("DVD reserved successfully");
            }
            else
            {
                Console.WriteLine("DVD not available");
            }
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }
    }

}
