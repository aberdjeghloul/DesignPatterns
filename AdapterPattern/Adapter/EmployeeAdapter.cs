using AdapterPattern.Adaptee;
using System.Collections.Generic;

namespace AdapterPattern.Adapter
{
    public class EmployeeAdapter : ThirdPartyEmployee, ITarget
    {
        public List<string> GetEmployees()
        {
            return GetEmployeeList();
        }
    }
}
