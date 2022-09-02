namespace OO_Programming_Problem_Statement_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company { Name = "Opteamix", incorporationDate = DateOnly.FromDateTime(DateTime.Now)};
          
            Customer customer1 = new Customer { customerId=101, Name="Sanjay", address="Mysore", age=20,emailId="sanjay@gmail.com"};
            Customer customer2 = new Customer { customerId = 102, Name = "Hemath", address = "Bangalore", age = 12, emailId = "hem@gmail.com" };

            Employee employee1 = new Employee { empId = 201, Name = "Jay", address = "Mandya", age = 25, basic = 25000, experience = 2 };
            Employee employee2 = new Employee { empId = 202, Name = "Raj", address = "Bangalore", age = 27, basic = 35000, experience = 4 };

            Branch other1= new Branch { Name="newa"};
            Branch other2= new Branch { Name="news"};
            Branch corporate = new Branch { Name = "opt" };
            Branch registeres = new Branch { Name = "pratian" };

            company.employees.Add(employee1);
            company.employees.Add(employee2);

            company.customers.Add(customer1);
            company.customers.Add(customer2);

            company.corporate=corporate;
            company.registered = registeres;

            company.others.Add(other1);
            company.others.Add(other2);

            Console.WriteLine("Company Name:"+company.Name);
            Console.WriteLine("Incorporation Date:" + company.incorporationDate);
            Console.WriteLine("Total Customers:");
            Console.WriteLine(company.getTotalCustomers());
            Console.WriteLine("Enter Employee Id:");
            long id = long.Parse(Console.ReadLine());
            Employee employee = company.getEmployeeByEmpId(id);
            if (employee == null)
            {
                Console.WriteLine("Employee Id is not Found");
            }
            else
            {
                Console.WriteLine("Employee Details:");
                Console.WriteLine("Name:"+employee.Name);
                Console.WriteLine("Address:" + employee.address);
                Console.WriteLine("Age:" + employee.age);
                Console.WriteLine("Experince:" + employee.experience);
                Console.WriteLine("Basic:" + employee.basic);
                Console.WriteLine("Total Salary:" + employee.getSalary());
            }
            Console.WriteLine("Enter Employee Experience:");
            int exp = int.Parse(Console.ReadLine());
            List<Employee> list = company.getExperiencedEmployees(exp);
            if (list == null)
            {
                Console.WriteLine("No Exper");
            }
            else
            {
                foreach (Employee emp in list)
                {
                    Console.WriteLine("Employee Details:");
                    Console.WriteLine("Name:" + emp.Name);
                    Console.WriteLine("Address:" + emp.address);
                    Console.WriteLine("Age:" + emp.age);
                    Console.WriteLine("Experince:" + emp.experience);
                    Console.WriteLine("Basic:" + emp.basic);
                    Console.WriteLine("Total Salary:" + employee.getSalary());
                }
            }
        }
    }
}