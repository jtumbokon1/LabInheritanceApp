using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInheritance
{
    public class Employee
    {
        private string id;
        private string name;
        private string address;

        //public Employee() { }

        public string Id { get { return id; } }
        public string Name { get { return name; } }
        public string Address { get { return address; } }
        public string phone { get; set; }
        public Employee(string id, string name, string address, string phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
    }
}
