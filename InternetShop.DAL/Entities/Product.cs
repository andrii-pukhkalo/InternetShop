using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetShop.DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ProductDetails Details { get; set; }
    }
}
