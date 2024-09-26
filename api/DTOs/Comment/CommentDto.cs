using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs.Comment
{
    public class CommentDto
    {
        public int Id {get; set;}
        public int? StockId {get; set;} // Navigation property
        public string Title {get; set;} = string.Empty;
        public string Content {get; set;} = string.Empty;
        public DateTime CreatedOn {get; set;} = DateTime.Now;
    }
}