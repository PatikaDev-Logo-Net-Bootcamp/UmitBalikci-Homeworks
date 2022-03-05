using System.ComponentModel.DataAnnotations;

namespace HomeworkOne.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Ad alanı zorunlu alandır")]
        [Display(Name = "Ad*")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunlu alandır")]
        [Display(Name = "Soyad*")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email alanı zorunlu alandır")]
        [RegularExpression("^[A-Za-z0-9](([_\\.\\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\\.\\-]?[a-zA-Z0-9]+)*)\\.([A-Za-z]{2,})$", ErrorMessage = "Lütfen uygun formatta giriş yapın")]
        [Display(Name = "Email*")]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunlu alandır")]
        [MinLength(8, ErrorMessage = "Şifre alanı en az 8 karakter olmalı")]
        [RegularExpression("^(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "Şifre alanı bir büyük harf, bir karakter ve bir sayı içermeli!")]
        [Display(Name = "Şifre*")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
