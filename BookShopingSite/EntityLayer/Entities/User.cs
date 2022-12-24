using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityLayer.Entities
{
    public class User
    {
        public int Id { get; set; }
        //Name kısmını doldurmayı zorunlu yaptım ve doldurulmadıgında hata mesajı verdirdim.
        [Required(ErrorMessage = "Bu alani doldurmak zorunludur.")]
        [Display(Name = "Ad")]
        //Veri tabanında sisme yapmaması icin 50 karakterle sınırladım.
        [StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır")]
        public string Name { get; set; }
        //Surname kısmını doldurmayı zorunlu yaptım ve doldurulmadıgında hata mesajı verdirdim.
        [Required(ErrorMessage = "Bu alani doldurmak zorunludur.")]
        [Display(Name = "Soyad")]
        //Veri tabanında sisme yapmaması icin 50 karakterle sınırladım.
        [StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır")]
        public string Surname { get; set; }
        //Email kısmını doldurmayı zorunlu yaptım ve doldurulmadıgında hata mesajı verdirdim.
        [Required(ErrorMessage = "Bu alani doldurmak zorunludur.")]
        [Display(Name = "E-Mail")]
        //Veri tabanında sisme yapmaması icin 50 karakterle sınırladım.
        [StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır")]
        //E Mail adresi dogru girip girmedigini kontrol ederek dogru girilmemisse uyari mesaji verdirdim.
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir E-Mail adresi giriniz.")]
        public string Email { get; set; }
        //UserName kısmını doldurmayı zorunlu yaptım ve doldurulmadıgında hata mesajı verdirdim.
        [Required(ErrorMessage = "Bu alani doldurmak zorunludur.")]
        [Display(Name = "Kullanıcı adı")]
        //Veri tabanında sisme yapmaması icin 10 karakterle sınırladım.
        [StringLength(10, ErrorMessage = "En fazla 10 karakter olmalıdır")]
        public string UserName { get; set; }
        //Password kısmını doldurmayı zorunlu yaptım ve doldurulmadıgında hata mesajı verdirdim.
        [Required(ErrorMessage = "Bu alani doldurmak zorunludur.")]
        [Display(Name = "Şifre")]
        //Veri tabanında sisme yapmaması icin 10 karakterle sınırladım.
        [StringLength(10, ErrorMessage = "En fazla 10 karakter olmalıdır")]
        //Data type'ı password olarak belirttim.
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //Password kısmını doldurmayı zorunlu yaptım ve doldurulmadıgında hata mesajı verdirdim.
        [Required(ErrorMessage = "Bu alani doldurmak zorunludur.")]
        [Display(Name = "Şifre")]
        //Veri tabanında sisme yapmaması icin 10 karakterle sınırladım.
        [StringLength(10, ErrorMessage = "En fazla 10 karakter olmalıdır")]
        //Data type'ı password olarak belirttim.
        [DataType(DataType.Password)]
        //Girilen şifrelerin uyuşup uyuşmadığını compare kullanarak kontrl ettim eğer uyuşmuyorsa hata mesajı verdirdim.
        [Compare("Password", ErrorMessage = "!Girdiğiniz şifreler birbirinden farklı.")]
        public string RePassword { get; set; }
        public string Role { get; set; }

    }
}
