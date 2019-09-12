using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Entities
{
    internal class Image
    {
        public int ID { get; set; }
        public ClothingItem ClothingItem { get; set; }
        public string Link { get; set; }
    }
}
