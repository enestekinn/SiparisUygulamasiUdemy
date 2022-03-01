using Microsoft.EntityFrameworkCore;
using SiparisUygulamasiUdemy.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisUygulamasiUdemy.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {


        //dependency injection
        private readonly ApplicationDbContext _context;
        internal DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();

        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);

            
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = _dbSet;
            if (filter != null)
            {
               // x=> x id == 1  parametredeki filter bunu temsil ediyor.
                query = query.Where(filter);
            }
            // Product, Order product ve order gelicek bunlarla ayri ayri islem yapacak 
            if (includeProperties != null)
            {
                // ardi ardina 2 virgul atildiysa aradan cikar 
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
            return query.ToList();
        }



        public T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = _dbSet;
            if (filter != null)
            {
                // x=> x id == 1  parametredeki filter bunu temsil ediyor.
                query = query.Where(filter);
            }
            // Product, Order product ve order gelicek bunlarla ayri ayri islem yapacak 
            if (includeProperties != null)
            {
                // ardi ardina 2 virgul atildiysa aradan cikar 
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
