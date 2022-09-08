
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Programming_Problem_Statement_Solution
{
    public class Company
    {
        public string Name { get; set; }
        public DateOnly incorporationDate { get; set; }
        public List<Customer> customers { get; set; } = new List<Customer>();
        public List<Employee> employees { get; set; }= new List<Employee>();

        public List<Branch> others { get; set; } = new List<Branch>();
        public Branch registered { get; set; }
        public Branch corporate { get; set; }

        public int getTotalCustomers()
        {
            return customers.Count;
        }
        public float getToatalSalaryPayout()
        {
            float total = 0;
            var empMax = employees.ToList();

            foreach (var emp in employees)
            {
                total += emp.getSalary();
            }
            return total;
        }
        public Employee getEmployeeByEmpId(long id)
        {
            Employee employee = (from emp in employees
                                where emp.empId==id
                                select emp).FirstOrDefault();
            
            return employee;
        }
        public List<Employee> getExperiencedEmployees(int yearsOfExperience)
        {
            List<Employee> employexp = (from emp in employees
                             where emp.experience==yearsOfExperience
                             select emp).ToList();


            return employexp;
        }
        public List<Employee> getEmployeesGroupedByAge()
        {
            List<Employee> empage = employees.OrderBy(x=> x.age).ToList();

            return empage;
        }
    }
}
