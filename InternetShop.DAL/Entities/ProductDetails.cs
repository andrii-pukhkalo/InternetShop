using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetShop.DAL.Entities
{
    public class ProductDetails
    {
        [Key]
        [ForeignKey("Product")]
        public int Id { get; set; }
        public decimal Price { get; set; }

        public Product Product { get; set; }
    }
}
