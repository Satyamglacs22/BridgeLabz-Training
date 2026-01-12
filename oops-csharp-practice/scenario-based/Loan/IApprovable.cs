using System;
using System.Collections.Generic;
using System.Text;

namespace Loan
{
    internal interface IApprovable
    {
        void ApproveLoan();
        double CalculateEMI();
    }
}
