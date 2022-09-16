using System;

namespace OnlineShop.Models.DomainModels
{
    public class FileModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public string Format { get; set; }
        public string PhysicalPath { get; set; }
        public int Size { get; set; }
        public bool IsDownloadable { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
