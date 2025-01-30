using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInheritance
{
    public class Employee
    {
        // private data
        private string id;
        private string name;
        private string address;
        private string phone;
        private long sin;
        private string dob;
        private string dept;

        // public properties
        public string Id { get { return id; } }
        public string Name { get { return name; } }    
        public string Address { get { return address; } }
        public string Phone { get { return phone; } }
        public long Sin { get { return sin; } }
        public string Dob { get { return dob; } }
        public string Dept { get { return dept; } }

        // constructors
        public Employee(string id, string name, string address, string phone, long sin, string dob, string dept)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
        }

        // public methods
        public virtual double getPay()
        {
            return 0;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
