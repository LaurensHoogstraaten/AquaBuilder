using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AquaBuilder.DTO;

namespace AquaBuilder.Models
{
    public class ProductModel
    {
        public int productId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public byte[] image { get; set; }
        public int supply { get; set; }

        public ProductModel(ProductDTO DTO)
        {
            productId = DTO.productId;
            name = DTO.name;
            description = DTO.description;
            price = DTO.price;
            image = DTO.image;
            supply = DTO.supply;
        }
    }
}
