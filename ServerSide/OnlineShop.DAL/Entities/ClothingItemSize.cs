using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Entities
{
    internal class ClothingItemSize
    {
        public int ID { get; set; }
        public ClothingItem ClothingItem { get; set; }
        public Size Size { get; set; }
    }
}
