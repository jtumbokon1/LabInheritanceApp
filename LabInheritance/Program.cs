
using System.Reflection.Metadata;
using LabInheritance;

class Program
{
    private const string PATH = @"..\..\..\res\employees.txt"; // relative to .exe file
    private const char sep = ':'; // seperator of line fields
    public static void Main()
    {
        List<Employee> ReadFromFile()
        {
            List<Employee> employees = new List<Employee>(); // empty list
            StreamReader reader = new StreamReader(PATH);
            string line; // for reading - whole line
            string[] fields; // individual fields in the line
            Employee emp = null; // new employee
            while (!reader.EndOfStream) // while there is data to read
            {
                line = reader.ReadLine();
                fields = line.Split(sep);
                // fields[0] is id
                // fields[1] is name
                // fields[2] is address
                // fields[3] is phone
                switch (fields.Length)
                {
                    case 4: // salaried employee
                        emp = new Salaried(fields[0], fields[1], fields[2], fields[3], Convert.ToInt64(fields[4]));
                        break;
                    case 5: // part-time employee
                        emp = new PartTime(fields[0], fields[1], fields[2], fields[3], Convert.ToInt64(fields[4]));
                        break;
                    case 6: // wage employee
                        emp = new Wages(fields[0], fields[1], fields[2], fields[3], Convert.ToInt64(fields[4]));
                        break;
                }
                employees.Add(emp);
            }
            return employees;
        }             
    } // main
} // class