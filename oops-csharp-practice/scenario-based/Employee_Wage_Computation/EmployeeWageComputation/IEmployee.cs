using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation.EmployeeWageComputation
{
    public interface IEmployee
    {
        Employee AddEmployee(int id, string name);

        void CheckAttendance(Employee employee);                 // UC1
        void CalculateDailyWage(Employee employee);              // UC2 + UC3
        void CalculateDailyWageUsingSwitch(Employee employee);   // UC4
        void CalculateMonthlyWage(Employee employee);            // UC5
    }
}
