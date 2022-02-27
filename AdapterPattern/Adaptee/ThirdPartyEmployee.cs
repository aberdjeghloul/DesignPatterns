using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Adaptee
{
    public class ThirdPartyEmployee
    {
        public List<string> GetEmployeeList()
        {
            List<string> EmployeeList = new List<string>();
            EmployeeList.Add("Bob");
            EmployeeList.Add("Joe");

            return EmployeeList;
        }
    }
}
