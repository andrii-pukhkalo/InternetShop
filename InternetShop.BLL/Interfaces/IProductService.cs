using InternetShop.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.BLL.Interfaces
{
    public interface IProductService
    {
        void CreateProduct(ProductDTO productDto);
        IEnumerable<ProductDTO> GetProducts();
        void Dispose();
    }
}
