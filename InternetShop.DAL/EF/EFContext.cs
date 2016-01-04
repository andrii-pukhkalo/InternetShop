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
        public DbSet<Category> Categories               { get; set; }

        //static EFContext()
        //{
        //    Database.SetInitializer<EFContext>(new StoreDbInitializer());
        //}
        public EFContext(string connectionString)
            : base(connectionString)
        {
        }

        public EFContext() : base("InternetShop") { }

    }

    //public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<EFContext>
    //{
    //    protected override void Seed(EFContext db)
    //    {
    //        Product product1 = new Product { Name = "Nokia Lumia 630" };
    //        Product product2 = new Product { Name = "Apple Iphone 6S" };
    //        Product product3 = new Product { Name = "Samsung GALAXY S6" };

    //        db.Products.AddRange(new List<Product> { product1, product2, product3 });
    //        db.SaveChanges();

    //        ProductDetails productDetails1 = new ProductDetails { Id = product1.Id, Price = 100 };
    //        ProductDetails productDetails2 = new ProductDetails { Id = product2.Id, Price = 500 };
    //        ProductDetails productDetails3 = new ProductDetails { Id = product3.Id, Price = 300 };

    //        db.ProductDetails.AddRange(new List<ProductDetails> { productDetails1, productDetails2, productDetails3 });
    //        db.SaveChanges();
    //    }
    //}
}
