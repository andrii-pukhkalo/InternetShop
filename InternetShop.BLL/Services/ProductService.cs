using System.Collections.Generic;
using InternetShop.BLL.DTO;
using InternetShop.BLL.Interfaces;
using InternetShop.DAL.Interfaces;
using InternetShop.DAL.Entities;
using AutoMapper;

namespace InternetShop.BLL.Services
{
    public class ProductService : IProductService
    {
        private IUnitOfWork Database { get; set; }

        // constructor
        public ProductService(IUnitOfWork uow) {
            this.Database = uow;
        }

        public void CreateProduct(ProductDTO productDto)
        {
            Product product = new Product { Name = productDto.Name };

            Database.Products.Create(product);
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            return Mapper.Map<IEnumerable<Product>, List<ProductDTO>>(Database.Products.GetAll());
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
