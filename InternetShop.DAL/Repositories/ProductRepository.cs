using System.Collections.Generic;
using InternetShop.DAL.Entities;
using InternetShop.DAL.Interfaces;
using InternetShop.DAL.EF;
using System.Linq;
using System;

namespace InternetShop.DAL.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private EFContext db;

        public ProductRepository(EFContext ctx)
        {
            this.db = ctx;
        }

        public void Create(Product item)
        {
            db.Products.Add(item);
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products.Include("Details").ToList();
        }

        public Product GetById(int id)
        {
            return db.Products.Find(id);
        }
    }
}
