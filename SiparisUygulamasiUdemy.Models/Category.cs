using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisUygulamasiUdemy.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }

        [Required] // bos gecilmez.
        public string Name { get; set; }
    }
}
