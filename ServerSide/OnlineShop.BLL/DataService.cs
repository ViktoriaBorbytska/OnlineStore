using OnlineShop.Interfaces.BLL;
using OnlineShop.Interfaces.DAL.Repositories;
using OnlineShop.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.BLL
{
    public class DataService : IDataService
    {
        private readonly IDataRepository dataRepository;

        public DataService(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }

        public IReadOnlyCollection<ClothingItemModel> GetNewArrivals() =>
            dataRepository.GetNewArrivals();
    }
}
