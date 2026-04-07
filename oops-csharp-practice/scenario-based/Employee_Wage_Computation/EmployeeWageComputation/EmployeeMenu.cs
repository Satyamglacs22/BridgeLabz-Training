using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation.EmployeeWageComputation
{
    public sealed class EmployeeMenu
    {
        private IEmployee service;
        private Employee employee;

        public EmployeeMenu()
        {
            service = new EmployeeUtilityImpl();
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Console.Write("Enter Employee Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            employee = service.AddEmployee(id, name);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nSelect Use Case:");
                Console.WriteLine("1. UC-4 : Daily Wage using Switch Case");
                Console.WriteLine("2. UC-5 : Monthly Wage (Random Working Days)");
                Console.WriteLine("3. UC-6 : Wage till 100 Hours or 20 Days");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.CheckAttendance(employee);
                        service.CalculateDailyWageUsingSwitch(employee);
                        break;

                    case 2:
                        service.CalculateMonthlyWage(employee);
                        break;

                    case 3:
                        service.CalculateWageWithCondition(employee);
                        break;

                    case 4:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

            Console.WriteLine("Program Ended");
        }
    }
}
