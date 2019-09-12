using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Entities
{
    internal class ClothingItemType
    {
        public int ID { get; set; }
        public ClothingItem ClothingItem { get; set; }
        public ClothingType ClothingType { get; set; }
    }
}
