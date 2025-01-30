using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInheritance
{
    public class PartTime : Employee
    {
        // private data
        private double rate;
        private double hours;
       
        // public properties
        public double Rate 
        { 
            get { return rate; }
            set { rate = value >= 0 ? value : 0; }
        }
        public double Hours
        {
            get { return hours; }
            set { hours = value >= 0 ? value : 0; }
        }

        // constructor
        public PartTime(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours) : 
            base(id, name, address, phone, sin, dob, dept)
        {
            this.rate = rate;
            this.hours = hours;
        }

        // public methods
        public override double getPay()
        {
            return rate * hours;
        }
        public override string ToString()
        {
            return $"{base.ToString()}Pay: {getPay():C}";
        }
    }// class
}// namespace
