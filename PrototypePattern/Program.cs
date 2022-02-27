using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.FirstName = "Joe";
            employee1.LastName = "Anderson";
            employee1.Department = "IT";            
            employee1.EmpAddress = new Address() { Number = 25, Street = "rue Pasteur", ZipCode = "95390" };
            
            Employee employee2 = (Employee)employee1.Clone();
            employee2.FirstName = "Bob";
            employee2.EmpAddress.Street = "rue des Lilas";

            Console.WriteLine($"{employee1.FirstName} {employee1.LastName} {employee1.Department} {employee1.EmpAddress.Number} {employee1.EmpAddress.Street} {employee1.EmpAddress.ZipCode}");
            Console.WriteLine($"{employee2.FirstName} {employee2.LastName} {employee2.Department} {employee2.EmpAddress.Number} {employee2.EmpAddress.Street} {employee2.EmpAddress.ZipCode}");            

            Console.ReadKey();
        }
    }
}
