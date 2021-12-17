using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication14.Models
{
    public class Pizza
    {
        public Guid Id { get; set; }
        
        public string Title { get; set; }
        public string ShortName { get; set; }
        public string StockStatus { get; set; }

        public string Ingredients { get; set; }
        public double Price { get; set; }
    }
}
