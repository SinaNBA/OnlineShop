using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Data.Entity
{
    public class File
    {


        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[DefaultValueSql("newId()")]
        public Guid Id { get; set; }
        //[Required]
        //[StringLength(100)]
        public string Name { get; set; }
        public int TypeId { get; set; }
        public virtual FileType FileType { get; set; }
        public string Format { get; set; }
        public string PhysicalPath { get; set; }
        public int Size { get; set; }
        public bool IsDownloadable { get; set; }
        public DateTime CreateAt { get; set; }
        public virtual List<ProductCategory> ProductCategories { get; set; }
        public virtual List<ProductFile> ProductFiles { get; set; }
    }
}
