using System;

namespace DataModel.Entity
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTimeOffset? BirthDate { get; set; }
        public virtual Department Department { get; set; }
    }
}
