using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _22_MVC_IdentityCustomize.Models.VMs
{
    public class RegisterVM
    {
        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Adınız")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Soyadınız")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Şifre")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Şifre Tekrar")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
