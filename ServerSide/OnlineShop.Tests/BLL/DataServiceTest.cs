using NUnit.Framework;
using OnlineShop.BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Tests.BLL
{
    public class DataServiceTest
    {
        [TestCase("GetNewArrivals Should return all clothes")]
        public void GetNewArrivalsTest()
        {
            DataService dataService = new DataService(new DataRepository());
        }

    }
}
