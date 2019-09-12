using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Entities
{
    internal class ClothingItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Fashion Fashion { get; set; }
        public Brand Brand { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool InStock { get; set; }
    }
}
