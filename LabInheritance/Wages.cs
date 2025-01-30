using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabInheritance
{
    public class Wages : Employee
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

        // constructors
        public Wages(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours) :
            base(id, name, address, phone, sin, dob, dept)
        {
            this.rate = rate;
            this.hours = hours;
        }
        // public methods
        public override double getPay()
        {
            if (hours <= 40)
            {
                return rate * hours;
            }
            else
            {
                return rate * 40 + (rate * 1.5 * (hours - 40));
            }
        }
    }// class
}// namespace
