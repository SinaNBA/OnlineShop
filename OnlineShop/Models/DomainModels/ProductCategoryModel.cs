using System;

namespace OnlineShop.Models.DomainModels
{
    public class ProductCategoryModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid FileId { get; set; }
        public int ParentId { get; set; }
    }
}
