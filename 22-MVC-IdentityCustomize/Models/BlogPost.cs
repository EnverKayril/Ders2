namespace _22_MVC_IdentityCustomize.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDate { get; set; } = DateTime.Now;
        public bool IsPublished { get; set; } = true;

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public string UserId { get; set; }
        public virtual AppUser User { get; set; }
    }
}
