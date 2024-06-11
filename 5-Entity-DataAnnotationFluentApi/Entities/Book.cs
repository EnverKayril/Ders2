using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Entity_DataAnnotationFluentApi.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; } // PrimaryKey, Identity

        [Required]
        [MaxLength(50)] // Db tarafonda kontrol eder.
        [StringLength(50)] // Nesne tarafında kontrol eder.
        public string Title { get; set; } // nvarchar(max) not null

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; } // nvarchar(max) is null

        [Range(0, 50)]
        public int Stock { get; set; }

        [Column("Açıklama", Order = 3, TypeName = "nvarchar(100)")]
        public string Description { get; set; }

        public int AuthorId { get; set; } // ForegeinKey

        // Navigation Property
        public Author Author { get; set; } // 1-N Relationship

        public BookDetail BookDetail { get; set; } // 1-1 Relationship


    }
}
