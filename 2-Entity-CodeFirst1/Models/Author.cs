using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Entity_CodeFirst1.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string Phone { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}

//add-migration initialCatalog
//update-database
//add-migration addPhoneNumberByAuthor
//remove-migration