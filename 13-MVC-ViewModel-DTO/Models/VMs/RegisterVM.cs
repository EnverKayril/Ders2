using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _13_MVC_ViewModel_DTO.Models.VMs
{
    public class RegisterVM
    {
        [Display(Name = "Adınızı Giriniz: ")]
        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyad alanı zorunludur.")]
        [Display(Name = "Soyadınızı Giriniz: ")]
        public string LastName { get; set; }
        [Display(Name = "Email adresinizi giriniz: ")]
        [Required(ErrorMessage = "Email alanı zorunludur.")]
        //[DataType(DataType.EmailAddress, ErrorMessage = "Geçerli bir email adresi giriniz.")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz.")]
        public string Email { get; set; }
        [Display(Name = "Şifrenizi giriniz: ")]
        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        [DataType(DataType.Password)]
        [StringLength(50,MinimumLength =6, ErrorMessage = "Şifre en az 6 karakter olmalı")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$", ErrorMessage = "Password must contain.")]
        //Regex Expression
        public string Password { get; set; }
        [Display(Name = "Şifrenizi tekrar giriniz: ")]
        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
