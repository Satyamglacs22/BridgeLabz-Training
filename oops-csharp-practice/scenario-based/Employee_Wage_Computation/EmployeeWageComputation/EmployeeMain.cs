using Employee_Wage_Computation.EmployeeWageComputation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation.EmployeeWageComputation
{
    public class EmployeeMain
    {
        public static void Main(string[] args)
        {
            EmployeeMenu menu = new EmployeeMenu();
            menu.Start();
        }
    }
}
