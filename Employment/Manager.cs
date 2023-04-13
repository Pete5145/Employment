using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employment
{
    public class Manager: Employee
    {
        public string DepartmentName { get; set; } 

        public Manager(string firstName, string lastName, int age, int employeeID, int yearsOfExperience, string departmentName) : base(firstName, lastName, age, employeeID, yearsOfExperience)
        {
            DepartmentName = departmentName;
        }

        public decimal CalculateTeamPerformanceBonus()
        {
            decimal teamPerformanceBonus = 10000;
            return teamPerformanceBonus;
        }
        public override decimal CalculateSalary(decimal departmentBudget)
        {
            decimal baseSalary = 80000;

            decimal salary = baseSalary + (1000 * _yearsOfExperience) + (0.01m * departmentBudget) + CalculateTeamPerformanceBonus();
             
            return salary;
        }
       
    }
}
