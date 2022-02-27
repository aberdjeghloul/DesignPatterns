using AdapterPattern.Adapter;
using System;

namespace AdapterPattern
{
    public class Client
    {
        static void Main(string[] args)
        {
            ITarget adapter = new EmployeeAdapter();

            foreach (string employee in adapter.GetEmployees())
            {
                Console.WriteLine(employee);                
            }
            Console.ReadKey();
        }
    }
}
