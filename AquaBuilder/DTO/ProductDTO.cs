using AquaBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaBuilder.DTO
{
    public class ProductDTO
    {
        public int productId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public byte[] image { get; set; }
        public int supply { get; set; }

        public ProductDTO(ProductModel product)
        {
            productId = product.productId;
            name = product.name;
            description = product.description;
            price = product.price;
            image = product.image;
            supply = product.supply;
        }
    }
}
