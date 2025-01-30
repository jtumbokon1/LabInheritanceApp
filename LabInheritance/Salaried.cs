using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInheritance
{
    public class Salaried : Employee
    {
        // private data
        private double salary;

        // public properties
        public double Salary
        {
            get { return salary; }
            set { salary = value >= 0 ? value : 0; } 
        }

        // constructors
        public Salaried(string id, string name, string address, string phone, long sin, string dob, string dept, double salary) :
            base(id, name, address, phone, sin, dob, dept)
        {
            this.salary = salary;
        }

        // public methods
        public override double getPay()
        {
            return salary;
        }
        public override string ToString()
        {
            return $"{base.ToString()}Pay: {getPay():C}";
        }
    }// class
}// namespace
