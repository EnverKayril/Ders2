using _18_MVC_WebProject.Models.Enums;

namespace _18_MVC_WebProject.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public Status Status { get; set; } = Status.Created;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

    }
}
