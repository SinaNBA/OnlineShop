using System;
using System.Collections.Generic;

namespace OnlineShop.Data.Entity
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid FileId { get; set; }
        public virtual File File { get; set; }
        public int ParentId { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}