using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication14.Models
{
    public class Pizza
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ShortName { get; set; }
        [Required]
        public string StockStatus { get; set; }
        [Required]
        public string Ingredients { get; set; }
        public double Price { get; set; }
    }
}
