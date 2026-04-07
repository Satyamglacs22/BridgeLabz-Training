using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation.EmployeeWageComputation
{
    public interface IEmployee
    {
        Employee AddEmployee(int id, string name);

        void CheckAttendance(Employee employee);                 // UC-1
        void CalculateDailyWage(Employee employee);              // UC-2 + UC-3
        void CalculateDailyWageUsingSwitch(Employee employee);   // UC-4
        void CalculateMonthlyWage(Employee employee);            // UC-5
        void CalculateWageWithCondition(Employee employee);      // UC-6
    }
}
