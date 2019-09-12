using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Entities
{
    internal class ClothingItemColor
    {
        public int ID { get; set; }
        public ClothingItem ClothingItem { get; set; }
        public Color Color { get; set; }
    }
}
