using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs.Stock
{
    public class UpdateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol Cannot be over 10 characters")]
        public string Symbol {get; set;} = string.Empty;
        [Required]
        public string CompanyName {get; set;} = string.Empty;
        [Required]
        [Range(1,1000000000)]
        public decimal Purchase {get; set;}
        [Required]
        [Range(0.0001,100)]
        public decimal LastDiv {get; set;}
        [Required]
        [MaxLength(20, ErrorMessage = "Industry cannot be over 20 characters")]
        public string Industry {get; set;} = string.Empty;
        [Range(1,10000000000)]
        public long MarketCap {get; set;}
    }
}