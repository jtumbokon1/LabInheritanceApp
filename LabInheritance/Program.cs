/*
 * CPRG-211-C Lab Inheritance
 * Author: Jirch Tumbokon
 * When: Winter 2025
 */

/*
 * This program calculates the average weekly pay for all employees,
 * highest weekly pay for wage employees, lowest salary for salaried employees,
 * and the percentage of salaried, wage, and part-time employees.
 */

using LabInheritance;

class Program
{
    public static void Main()
    {
        double averagePay = Application.CalculateAveragePay(); // average pay of all employees
        Console.WriteLine($"Average weekly pay: {averagePay.ToString("c")}");

        var highestWageEmp = Application.GetHighestWage(); // highest weekly pay for wage employees and their name
        Console.WriteLine($"Highest weekly pay for wage employees is {highestWageEmp.name}: {highestWageEmp.pay.ToString("c")}");
        
        var lowestSalaryEmp = Application.GetLowestSalary(); // lowest salary for salaried employees and their name
        Console.WriteLine($"Lowest salary for salaried employees is {lowestSalaryEmp.name}: {lowestSalaryEmp.pay.ToString("c")}");

        var percentage = Application.GetPercentage(); // percentage of salaried, wage, and part-time employees
        Console.WriteLine($"Salaried Employees: {percentage.salariedPercentage.ToString("f2")}%");
        Console.WriteLine($"Wage Employees: {percentage.wagePercentage.ToString("f2")}%");
        Console.WriteLine($"Part-Time Employees: {percentage.partTimePercentage.ToString("f2")}%");
    }
}
