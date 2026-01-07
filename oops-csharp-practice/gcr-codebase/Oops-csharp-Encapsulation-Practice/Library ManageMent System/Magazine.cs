using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Library_ManageMent_System
{
    public class Magazine : LibraryItem
    {
        public override int GetLoanDuration()
        {
            return 7; // 7 days
        }
    }

}
