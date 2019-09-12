using OnlineShop.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Interfaces.BLL
{
    public interface IDataService
    {
        IReadOnlyCollection<ClothingItemModel> GetNewArrivals();
    }
}
