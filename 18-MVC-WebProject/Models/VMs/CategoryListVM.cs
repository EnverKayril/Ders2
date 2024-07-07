using _18_MVC_WebProject.Models.Enums;
using System.ComponentModel;

namespace _18_MVC_WebProject.Models.VMs
{
    public class CategoryListVM
    {
        [DisplayName("No")]
        public int Id { get; set; }
        [DisplayName("Kategori Adı")]
        public string Name { get; set; }
        [DisplayName("Eklenme Tarihi")]
        public DateTime CreateDate { get; set; }
        [DisplayName("Durumu")]
        public Status Status { get; set; }
    }
}
