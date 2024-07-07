using _18_MVC_WebProject.Models.Enums;

namespace _18_MVC_WebProject.Models.VMs
{
    public class ProductListVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
