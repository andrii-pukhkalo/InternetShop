using InternetShop.DAL.Interfaces;
using System;
using InternetShop.DAL.Entities;
using InternetShop.DAL.EF;


namespace InternetShop.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork, IDisposable
    {
        private EFContext db;
        private ProductRepository productRepository;
        private ProductDetailsRepository productDetailsRepository;

        public EFUnitOfWork(string connectionString) {
            db = new EFContext(connectionString);
        }

        public IRepository<Product> Products
        {
            get
            {
                if (productRepository == null)
                    this.productRepository = new ProductRepository(db);
                return productRepository;
            }
        }

        public IRepository<ProductDetails> ProductsDetails
        {
            get
            {
                if (productDetailsRepository == null)
                    this.productDetailsRepository = new ProductDetailsRepository(db);
                return productDetailsRepository;
            }
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                db.Dispose();
            }
            this.disposed = true;
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
