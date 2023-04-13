using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employment
{
    public class Employee: Person
    {
        public int EmployeeID { get; set; }

        public int _yearsOfExperience; 

        public Employee(string firstName, string lastName, int age, int employeeID, int yearsOfExperience): base(firstName, lastName, age)
        {
            EmployeeID = employeeID;
            _yearsOfExperience = yearsOfExperience;
        }

        public virtual decimal CalculateSalary(decimal departmentBudget)
        {
            decimal baseSalary = 50000;
                   
            decimal salary = baseSalary + (1000 * _yearsOfExperience) + ( 0.01m * departmentBudget);

            return salary;
        }
    }
}
