using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInheritance
{
    public class Salaried : Employee
    {
        private double salary;
        public double Salary { get { return salary; } }
        public long sin { get; set; }
        public Salaried(string id, string name, string address, string phone, long sin) : base(id, name, address, phone)
        {
        }

       
    }
}
