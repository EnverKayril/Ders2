using _13_MVC_ViewModel_DTO.Validations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _13_MVC_ViewModel_DTO.Models.VMs
{
    public class ProductVM
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        [Required(ErrorMessage = "Boş Geçilemez")]
        public string Name { get; set; }
        [CustomDateValidation(2023, 1, 1, ErrorMessage = "Tarih 2023-01-01 veya sonrası olmalıdır.")]
        public DateTime ReleaseDate { get; set; }
    }
}
