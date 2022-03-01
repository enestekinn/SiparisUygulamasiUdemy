using SiparisUygulamasiUdemy.Data.Repository.IRepository;
using SiparisUygulamasiUdemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisUygulamasiUdemy.Data.Repository
{
    public class OrderProductRepository : Repository<OrderProductRepository>, IOrderProductRepository
    {
        private ApplicationDbContext _context;
        public OrderProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Add(OrderProduct entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderProduct> GetAll(Expression<Func<OrderProduct, bool>>? filter = null, string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public OrderProduct GetFirstOrDefault(Expression<Func<OrderProduct, bool>> filter, string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(OrderProduct entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<OrderProduct> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(OrderProduct entity)
        {
            throw new NotImplementedException();
        }
    }
}
