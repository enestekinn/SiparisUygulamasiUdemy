using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisUygulamasiUdemy.Models
{
    public class Cart
    {

        public Cart()
        {
            // ilk acildiginda 1 olarak gelir.
            Count = 1;
        }

        [Key] public int Id { get; set; }
        public string AppUserId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        //Tablolar arasi baglandi

        [ForeignKey("AppUserId")]
        public AppUser App { get; set; }

        //Tablolar arasi baglandi
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

    }
}
