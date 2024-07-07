namespace _18_MVC_WebProject.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
