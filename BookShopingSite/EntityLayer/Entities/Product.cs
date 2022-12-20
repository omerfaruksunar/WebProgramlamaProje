using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityLayer.Entities
{
    public class Product
    {
        public int Id { get; set; }
        //Description kısmını doldurmayı zorunlu yaptım ve doldurulmadıgında hata mesajı verdirdim.
        [Required(ErrorMessage = "Bu alani doldurmak zorunludur.")]
        [Display(Name = "Açıklama")]
        //Veri tabanında sisme yapmaması icin 50 karakterle sınırladım.
        [StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır")]
        public string Description { get; set; }
        //Price kısmını doldurmayı zorunlu yaptım ve doldurulmadıgında hata mesajı verdirdim.
        [Required(ErrorMessage = "Bu alani doldurmak zorunludur.")]
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }
        //Stock kısmını doldurmayı zorunlu yaptım ve doldurulmadıgında hata mesajı verdirdim.
        [Required(ErrorMessage = "Bu alani doldurmak zorunludur.")]
        [Display(Name = "Stok")]
        public int Stock { get; set; }
        //Popular kısmını doldurmayı zorunlu yaptım ve doldurulmadıgında hata mesajı verdirdim.
        [Required(ErrorMessage = "Bu alani doldurmak zorunludur.")]
        [Display(Name = "Popüler")]

        public bool Popular { get; set; }
        //Popular kısmını doldurmayı zorunlu yaptım ve doldurulmadıgında hata mesajı verdirdim.
        [Required(ErrorMessage = "Bu alani doldurmak zorunludur.")]
        [Display(Name = "Onay")]
        public bool IsApproved { get; set; }
        //Image kısmını doldurmayı zorunlu yaptım ve doldurulmadıgında hata mesajı verdirdim.
        [Required(ErrorMessage = "Bu alani doldurmak zorunludur.")]
        [Display(Name = "Fotoğraf")]
        public string Image { get; set; }
        //Quantity kısmını doldurmayı zorunlu yaptım ve doldurulmadıgında hata mesajı verdirdim.
        [Required(ErrorMessage = "Bu alani doldurmak zorunludur.")]
        [Display(Name = "Adet")]
        public int Quantity { get; set; }
        //CategoryId kısmını doldurmayı zorunlu yaptım ve doldurulmadıgında hata mesajı verdirdim.
        [Required(ErrorMessage = "Bu alani doldurmak zorunludur.")]
        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
