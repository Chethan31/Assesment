using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Programming_Problem_Statement_Solution
{
    public class Employee : Person
    {
        public long empId { get; set; }
        public float basic { get; set; }
        public int experience { get; set; }
        public float getSalary()
        {
            float total_allowance = SalaryCalculator.calculateAllowance(experience, basic);
            float total_salary = total_allowance + basic;
            return total_salary;
        }

    }
}
