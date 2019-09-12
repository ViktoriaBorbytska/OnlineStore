using OnlineShop.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Interfaces.DAL.Repositories
{
    public interface IDataRepository
    {
        IReadOnlyCollection<ClothingItemModel> GetNewArrivals();
    }
}
