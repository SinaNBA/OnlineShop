using System;

namespace OnlineShop.Models.DomainModels
{
    public class ProductFileModel
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid FileId { get; set; }
        public bool IsDefault { get; set; }
        public Int16 Priority { get; set; }
    }
}
