using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Entity_CodeFirst1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? Page { get; set; }

        // Navigation Property
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
