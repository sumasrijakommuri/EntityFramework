using Employees.DataModel;
using Employees.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertEmployee();

            Console.ReadKey();
        }

        public static void InsertEmployee()
        {
            var address = new Address
            {
                AddressId = Guid.NewGuid().ToString(),
                StreetAddress1 = "113 Janelle Blvd",
                StreetAddress2 = "",
                City="Parsippany",
                State="NJ",
                Country="USA",
                ZipCode = "07054"
            };
            var emp = new Employee
            {
                EmployeeId = Guid.NewGuid().ToString(),
                FirstName = "Suma",
                LastName = "Kommuri",
                Email = "sumasrija@gmail.com",
                EmployeeVisa = VisaStatus.Citizen,
                AddressId = address.AddressId
            };

            using (var context = new EmployeeContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Addresses.Add(address);
                context.Employees.Add(emp);
                context.SaveChanges();
            }
        }
    }
}
