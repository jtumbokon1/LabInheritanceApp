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

        // public properties
        public double Rate { get { return rate; } }
        public long Sin { get; set; }
        public PartTime(string id, string name, string address, string phone, long sin) : base(id, name, address, phone)
        {
            Sin = sin;
        }
    }
}
