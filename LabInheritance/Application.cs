using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LabInheritance
{
    public class Application
    {
        // constants
        private const string PATH = @"..\..\..\res\employees.txt"; // relative to .exe file
        private const char SEP = ':'; // separator of line fields

        // public methods
        public static List<Employee> ReadFromFile()
        {
            List<Employee> list = new List<Employee>(); // empty list
            StreamReader reader = new StreamReader(PATH);
            string line; // for reading the whole line
            string[] fields; // individual fields in the line

            while (!reader.EndOfStream) // while there is data to read
            {
                line = reader.ReadLine();
                fields = line.Split(SEP);
                // fields[0] is id
                // fields[1] is name
                // fields[2] is address
                // fields[3] is phone
                // fields[4] is sin
                // fields[5] is date of birth
                // fields[6] is department
                // fields[7] is rate or salary
                // fields[8] is hours
                Employee emp = null; // new employee
                if (fields[0].StartsWith("0") || fields[0].StartsWith("1") || fields[0].StartsWith("2") || fields[0].StartsWith("3") || fields[0].StartsWith("4")) // salaried employees
                {
                    emp = new Salaried(fields[0], fields[1], fields[2], fields[3],
                            Convert.ToInt64(fields[4]),
                            fields[5], fields[6],
                            Convert.ToDouble(fields[7]));
                }
                else if (fields[0].StartsWith("5") || fields[0].StartsWith("6") || fields[0].StartsWith("7")) // part-time employees
                {
                    emp = new Wages(fields[0], fields[1], fields[2], fields[3],
                            Convert.ToInt64(fields[4]),
                            fields[5], fields[6],
                            Convert.ToDouble(fields[7]),
                            Convert.ToDouble(fields[8]));
                }
                else if (fields[0].StartsWith("8") || fields[0].StartsWith("9"))// wage employees
                {
                    emp = new PartTime(fields[0], fields[1], fields[2], fields[3],
                            Convert.ToInt64(fields[4]),
                            fields[5], fields[6],
                            Convert.ToDouble(fields[7]),
                            Convert.ToDouble(fields[8]));
                }
                list.Add(emp);
            }
            return list;
        }

        public static double CalculateAveragePay()
        {
            List<Employee> employees = ReadFromFile();
            return employees.Count > 0 ? employees.Average(e => e.getPay()) : 0; ;
        }

        public static (string name, double pay) GetHighestWage()
        {
            List<Wages> wageEmployees = ReadFromFile().OfType<Wages>().ToList();
            var highestWageEmp = wageEmployees.OrderByDescending(e => e.getPay()).First();
            return (highestWageEmp.Name, highestWageEmp.getPay());
        }

        public static (string name, double pay) GetLowestSalary()
        {
            List<Salaried> salariedEmployees = ReadFromFile().OfType<Salaried>().ToList();
            var lowestSalaryEmp = salariedEmployees.OrderBy(e => e.getPay()).First();
            return (lowestSalaryEmp.Name, lowestSalaryEmp.getPay());
        }
        public static (double salariedPercentage, double wagePercentage, double partTimePercentage) GetPercentage()
        {
            List<Employee> employees = ReadFromFile();
            double salaryCount = 0, 
                   wageCount = 0, 
                   partTimeCount = 0;
            foreach (Employee e in employees)
            {
               if (e is Salaried) salaryCount++;
               else if (e is Wages) wageCount++;
               else if (e is PartTime) partTimeCount++;
            }
            double salariedPercentage = salaryCount / employees.Count * 100;
            double wagePercentage = wageCount / employees.Count * 100;
            double partTimePercentage = partTimeCount / employees.Count * 100;

            return (salariedPercentage, wagePercentage, partTimePercentage);
        }
    } // class
} // namespace