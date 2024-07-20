using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _22_MVC_IdentityCustomize.Models.VMs
{
    public class LoginVM
    {
        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Şifre")]
        public string Password { get; set; }
        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }

    }
}
