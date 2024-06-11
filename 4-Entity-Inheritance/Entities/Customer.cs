using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Entity_Inheritance.Entities
{
    public class Customer : BasePerson
    {
        public int TotalVisit { get; set; }
        public int OrderCount { get; set; }

    }
}
