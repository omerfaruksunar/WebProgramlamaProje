using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Category
    {
        public int Id { get; set; }
        //Name kısmını doldurmayı zorunlu yaptım ve doldurulmadıgında hata mesajı verdirdim.
        [Required(ErrorMessage = "Bu alani doldurmak zorunludur.")]
        [Display(Name = "Ad")]
        //Veri tabanında sisme yapmaması icin 50 karakterle sınırladım.
        [StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır")]
        public string Name { get; set; }
        //Aciklama kısmını doldurmayı zorunlu yaptım ve doldurulmadıgında hata mesajı verdirdim.
        [Required(ErrorMessage = "Bu alani doldurmak zorunludur.")]
        [Display(Name = "Açıklama")]
        //Veri tabanında sisme yapmaması icin 50 karakterle sınırladım.
        [StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır")]
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }


    }
}
