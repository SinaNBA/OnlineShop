using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Data.Entity
{
    public class FileType
    {
        
        public int Id { get; set; }        
        public string Title { get; set; }
        public virtual List<File> Files { get; set; }
    }
}
