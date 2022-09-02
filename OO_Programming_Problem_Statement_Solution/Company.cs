
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
        public List<Customer> customers { get; set; }
        public List<Employee> employees { get; set; }

        public List<Branch> others { get; set; }
        public Branch registered { get; set; }
        public Branch corporate { get; set; }
    }
}
