using System.ComponentModel.DataAnnotations;

namespace _19_MVC_Identity.Models.VMs
{
    public class LoginVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
