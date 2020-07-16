using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateRealTimeApp
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 1, Name = "subro", Salary = 5, Experience = 10 });
            employees.Add(new Employee { Id = 2, Name = "sumit", Salary = 10, Experience = 2 });
            employees.Add(new Employee { Id = 3, Name = "likhon", Salary = 11, Experience = 6 });
            employees.Add(new Employee { Id = 4, Name = "suvo", Salary = 20, Experience = 9 });

            //Step 1 Using Delegate

            //IsPromoted isPromoted = new IsPromoted(Promoted);
            //Employee.PromoteEmployee(employees, isPromoted);
            //public static bool Promoted(Employee employee)
            //{
            //    if (employee.Salary > 5)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}

            //Step 2 using Anonymus Method
            //Predicate<Employee> emplo = new Predicate<Employee>(IsTrue);
            Employee emp = employees.Find(
            delegate(Employee obj)
            {
                return obj.Id == 3;
            }
            );

            Console.WriteLine(emp.Name);

            IsPromoted isPromoted = delegate (Employee employee)
            {
                if (employee.Salary > 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            //Step 3 Using Lambda Expression
            //IsPromoted isPromoted = employee => employee.Salary > 5;

            //Step 4
            Employee.PromoteEmployee(employees, employee => employee.Salary > 5);

            Console.ReadLine();
        }

        private static bool IsTrue(Employee obj)
        {
            return obj.Id == 3;
        }
    }
}
