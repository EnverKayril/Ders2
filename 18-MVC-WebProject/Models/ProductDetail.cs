namespace _18_MVC_WebProject.Models
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string? Color { get; set; }
        public string? Detail { get; set; }
        public virtual Product Product { get; set; }
    }
}
