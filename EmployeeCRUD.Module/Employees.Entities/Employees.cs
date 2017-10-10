using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employees.Entities
{
    public class Employee
    {
        [Key]
        public string EmployeeId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public VisaStatus EmployeeVisa { get; set; }

        [ForeignKey("Address")]
        public string AddressId { get; set; }

        public Address Address { get; set; }
    }


    public class Address
    {
        [Key]
        public string AddressId { get; set; }

        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}

