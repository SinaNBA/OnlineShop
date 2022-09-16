using System;

namespace OnlineShop.Data.Entity
{
    public class ProductFile
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        public Guid FileId { get; set; }
        public virtual File File { get; set; }
        public bool IsDefault { get; set; }
        public Int16 Priority { get; set; }
    }
}
