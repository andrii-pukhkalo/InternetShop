using InternetShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace InternetShop.DAL.EF
{
    public class EFContext : DbContext
    {
        public DbSet<Product>           Products        { get; set; }
        public DbSet<ProductDetails>    ProductDetails  { get; set; }

        static EFContext()
        {
            Database.SetInitializer<EFContext>(new StoreDbInitializer());
        }
        public EFContext(string connectionString)
            : base(connectionString)
        {
        }
    }

    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<EFContext>
    {
        protected override void Seed(EFContext db)
        {
            Product product = new Product { Name = "Nokia Lumia 630" };

            db.Products.AddRange(new List<Product> { product });
            db.SaveChanges();

            ProductDetails productDetails = new ProductDetails { Id = product.Id, Price = 100 };

            db.ProductDetails.AddRange(new List<ProductDetails> { productDetails });
            db.SaveChanges();

            foreach (Product item in db.Products.Include("Product").ToList())
                Console.WriteLine("Name: {0}  Price: {1}",
                        item.Name, item.Details.Price);
        }
    }
}
