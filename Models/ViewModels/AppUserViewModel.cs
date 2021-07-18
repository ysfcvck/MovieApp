using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.ViewModels
{
    public class AppUserViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adını boş geçmeyiniz...")]
        [StringLength(15, ErrorMessage = "Lütfen kullanıcı adını 4 ile 15 karakter arasında giriniz...", MinimumLength = 4)]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Lütfen 'Ad Soyad' alanını doldurun...")]
        [Display(Name = "Ad Soyad")]
        public string NameSurname { get; set; }


        [Required(ErrorMessage = "Lütfen 'Telefon Numarası' alanını doldurun...")]
        [Phone(ErrorMessage = "Lütfen bir telefon numarası giriniz...")]
        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Lütfen emaili boş geçmeyiniz...")]
        [EmailAddress(ErrorMessage = "Lütfen email formatında bir değer belirtiniz...")]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Lütfen şifreyi boş geçmeyiniz...")]
        [DataType(DataType.Password, ErrorMessage = "Lütfen şifreyi tüm kuralları göz önüne alarak giriniz...")]
        [Display(Name = "Şifre")]
        public string Sifre { get; set; }
    }
}
