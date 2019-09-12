using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Interfaces;
using OnlineShop.Interfaces.DAL.Repositories;
using OnlineShop.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DAL.Repositories
{
    internal class DataRepository : IDataRepository
    {
        private readonly IApplicationDbContext context;

        public DataRepository(IApplicationDbContext context)
        {
            this.context = context;
        }

        public IReadOnlyCollection<ClothingItemModel> GetNewArrivals() =>
            Map(context.ClothingItems.Where(item => item.ID < 5).ToList());

        private ClothingItemModel Map(ClothingItem item)
        {
            var model = new ClothingItemModel
            {
                ID = item.ID,
                Name = item.Name,
                Price = item.Price,
                Description = item.Description,
                Images = new List<string>()
            };

            model.Images.Add(context.Images.FirstOrDefault(image => image.ClothingItem == item).Link);

            return model;
        }

        private IReadOnlyCollection<ClothingItemModel> Map(List<ClothingItem> items)
        {
            var modelCollection = new List<ClothingItemModel>();

            foreach (ClothingItem item in items)
            {
                modelCollection.Add(Map(item));
            }

            return modelCollection;
        }
    }
}
