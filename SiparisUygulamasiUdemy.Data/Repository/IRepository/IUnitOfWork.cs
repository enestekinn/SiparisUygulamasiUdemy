using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisUygulamasiUdemy.Data.Repository.IRepository
{
    // disposable gonderdigimiz islemler bittikten sonra ramde tutulmasini istemiyoruz
    public interface IUnitOfWork : IDisposable
    {

        IAppUserRepository AppUser { get; }
        ICartRepository Cart { get; }
        ICategoryRepository Category { get; }
        IOrderDetailsRepository OrderDetails { get; }
        IOrderProductRepository OrderProduct { get; }
        IProductRepository Product { get; }

        void Save();
    }
}
