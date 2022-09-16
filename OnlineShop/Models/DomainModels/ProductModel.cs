using System;

namespace OnlineShop.Models.DomainModels
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
