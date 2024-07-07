namespace _18_MVC_WebProject.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string? Image { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }
    }
}
