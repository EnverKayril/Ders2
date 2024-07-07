using System.ComponentModel.DataAnnotations;

namespace _17_MVC_Entity.Models.VMs
{
    public class CreateProductVM
    {
        [Display(Name = "Ürün Adı"), Required(ErrorMessage ="Ürün Adı Zorunludur.")]
        public string Name { get; set; }
        [Display(Name = "Ürün Adı"), Required(ErrorMessage = "Ürün Fiyatı Zorunludur.")]
        public double Price { get; set; }
    }
}
