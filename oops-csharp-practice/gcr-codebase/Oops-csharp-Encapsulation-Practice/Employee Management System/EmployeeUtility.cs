using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_csharp_Encapsulation_Practice.Employee_Management_System
{
    public class EmployeeUtility
    {
        public void Run()
        {
            // Polymorphic collection
            List<Employee> employees = new List<Employee>();

            FullTimeEmployee fullTimeEmp = new FullTimeEmployee(50000);
            fullTimeEmp.EmployeeId = 101;
            fullTimeEmp.Name = "Rahul";
            fullTimeEmp.AssignDepartment("IT");

            PartTimeEmployee partTimeEmp = new PartTimeEmployee(40, 300);
            partTimeEmp.EmployeeId = 102;
            partTimeEmp.Name = "Amit";

            employees.Add(fullTimeEmp);
            employees.Add(partTimeEmp);

            foreach (Employee emp in employees)
            {
                emp.DisplayDetails();

                // Interface-based access
                if (emp is IDepartment)
                {
                    IDepartment dept = (IDepartment)emp;
                    Console.WriteLine("Department    : " + dept.GetDepartmentDetails());
                }

                Console.WriteLine("--------------------------");
            }
        }
    }

}
