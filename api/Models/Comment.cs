using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Comments")]
    public class Comment
    {
        public int Id {get; set;}
        public int? StockId {get; set;} // Navigation property
        public string Title {get; set;} = string.Empty;
        public string Content {get; set;} = string.Empty;
        public DateTime CreatedOn {get; set;} = DateTime.Now;
        public Stock? Stock {get; set;}
    }
}