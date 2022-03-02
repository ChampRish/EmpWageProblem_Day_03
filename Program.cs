using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage");
            Console.ReadLine();
             UC1_EmpAttendance.CheckEmployeePresence();
            Console.ReadLine();
            UC2_EmpWage.CalculateEmpWage();
            Console.ReadLine();
            UC3_PartTime.CalculatePartTime();
            Console.ReadLine();
            UC4_EmpWageUsingSwitch.CalculateEmpWageUsingSwitch();
            Console.ReadLine();
            UC5_EmpWageForMonth.CalculateWageForMonth();
            Console.ReadLine();
            UC6_maxWorkInMonth.CalculatemaxWorkInMonth();
            Console.ReadLine();
        }
    }
}
