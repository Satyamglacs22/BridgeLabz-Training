using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public interface IEmployee
    {
        Employee AddEmployee(int id, string name , double salary);
        void CheckAttendance(Employee employee); // UC-1

        
    }
}
