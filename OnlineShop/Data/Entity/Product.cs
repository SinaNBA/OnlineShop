using System;
using System.Collections.Generic;

namespace OnlineShop.Data.Entity
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual List<ProductFile> ProductFiles { get; set; }
    }
}
