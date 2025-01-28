using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInheritance
{
    public class Wages : Employee
    {
        public long sin;
        public Wages(string id, string name, string address, string phone, long sin) : base(id, name, address, phone)
        {
        }
    }
}
