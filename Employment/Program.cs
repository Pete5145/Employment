using System.Runtime.InteropServices.JavaScript;

namespace Employment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee john = new Employee("John", "Smith", 32, 1234, 5);
            Manager salesManager = new Manager("Jane", "Doe", 50, 9012, 20, "Sales"); 


            Console.WriteLine($"==============Details of {john.FirstName} {john.LastName}====================");
            Console.WriteLine($"Name: {john.FirstName} {john.LastName}\nAge: {john.Age}\nEmployeeID: {john.EmployeeID}\nYears of Experience: {john._yearsOfExperience}\nSalary: {john.CalculateSalary(500000m)}");
           
            Console.WriteLine($"==============Details of {salesManager.FirstName} {salesManager.LastName}====================");
            Console.WriteLine($"Name: {salesManager.FirstName} {salesManager.LastName}\nAge: {salesManager.Age}\nEmployeeID: {salesManager.EmployeeID}\nYears of Experience: {salesManager._yearsOfExperience}\nSalary: {salesManager.CalculateSalary(500000m)}");
        }
    }
}