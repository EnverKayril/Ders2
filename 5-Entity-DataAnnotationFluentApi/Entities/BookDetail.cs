using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Entity_DataAnnotationFluentApi.Entities
{
    public class BookDetail
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
