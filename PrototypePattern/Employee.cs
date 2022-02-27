using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Department { get; set; }
        public Address EmpAddress { get; set; }

        public Employee Clone()
        {
            Employee employee = (Employee)this.MemberwiseClone();
            employee.EmpAddress = EmpAddress.Clone();
            return employee;
        }
    }
}
