using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisUygulamasiUdemy.Models.ViewModels
{
    public class OrderVM
    {
        public OrderDetails OrderProduct { get; set; }

        public IEnumerable<OrderDetails> OrderDetails { get; set; }
    }
}
