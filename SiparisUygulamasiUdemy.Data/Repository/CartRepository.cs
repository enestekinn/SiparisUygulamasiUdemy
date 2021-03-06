using SiparisUygulamasiUdemy.Data.Repository.IRepository;
using SiparisUygulamasiUdemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisUygulamasiUdemy.Data.Repository
{
    internal class CartRepository : Repository<Cart>, ICartRepository
    {
        private ApplicationDbContext _context;
        public CartRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
