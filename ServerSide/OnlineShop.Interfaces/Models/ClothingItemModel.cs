using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Interfaces.Models
{
    public class ClothingItemModel
    {
        public int ID { get; set; }
        public string Name { get; set; }        
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
    }
}
