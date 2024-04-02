using System;
using System.Collections.Generic;

namespace _1_Entity_DbFirst
{
    public partial class Table
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Phone { get; set; }
    }
}
