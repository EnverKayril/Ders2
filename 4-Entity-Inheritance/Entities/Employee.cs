using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _4_Entity_Inheritance.Entities
{
    public class Employee : BasePerson
    {
        public string title { get; set; }
        public double Salary { get; set; }
    }
}
