using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateRealTimeApp
{
    public delegate bool IsPromoted(Employee employee);
    public class Employee
    {
        public int Id { get; set; }
        public int Salary { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employees,IsPromoted isPromoted)
        {
            foreach (Employee emp in employees)
            {
                if(isPromoted(emp))
                {
                    Console.WriteLine(emp.Name+" Is Promoted");
                }
            }
        }
    }
}
