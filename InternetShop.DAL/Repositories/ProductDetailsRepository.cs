using InternetShop.DAL.EF;
using InternetShop.DAL.Entities;
using InternetShop.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.DAL.Repositories
{
    public class ProductDetailsRepository : IRepository<ProductDetails>
    {
        private EFContext db;

        public ProductDetailsRepository(EFContext ctx) {
            this.db = ctx;
        }

        public void Create(ProductDetails item)
        {
            db.ProductDetails.Add(item);             
        }

        public IEnumerable<ProductDetails> GetAll()
        {
            return db.ProductDetails;
        }
    }
}
