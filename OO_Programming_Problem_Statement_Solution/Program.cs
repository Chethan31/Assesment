namespace OO_Programming_Problem_Statement_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company { Name = "Opteamix", incorporationDate = DateOnly.FromDateTime(DateTime.Now)};
          
            Customer customer1 = new Customer { customerId=101, Name="Sanjay", address="Mysore", age=20,emailId="sanjay@gmail.com"};
            Customer customer2 = new Customer { customerId = 102, Name = "Hemath", address = "Bangalore", age = 12, emailId = "hem@gmail.com" };

            Employee employee1= new Employee { empId=201, Name="Jay", address="Mandya", }





            Console.WriteLine("Company Name:"+company.Name);
            Console.WriteLine("Incorporation Date:" + company.incorporationDate);
            Console.WriteLine("Total Customers:");
            Console.WriteLine(company.getTotalCustomers());
        }
    }
}