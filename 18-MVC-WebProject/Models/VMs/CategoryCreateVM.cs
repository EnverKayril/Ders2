using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _18_MVC_WebProject.Models.VMs
{
    public class CategoryCreateVM
    {
        [DisplayName("Kategori Adı"),Required(ErrorMessage ="Kategori Ad Alanı Zorunludur."),MaxLength(50, ErrorMessage = "50 Karakterden uzun olamaz.")]
        public string Name { get; set; }
    }
}
