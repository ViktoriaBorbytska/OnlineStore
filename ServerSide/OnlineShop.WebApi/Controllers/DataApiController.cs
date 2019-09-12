using Microsoft.AspNetCore.Mvc;
using OnlineShop.Interfaces.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.WebApi.Controllers
{
    [Route("api/data")]
    [ApiController]
    public class DataApiController : Controller
    {
        private readonly IDataService dataService;

        public DataApiController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        [HttpGet]
        [Route("getnewarrivals")]
        public IActionResult Get()
        {
            return Json(dataService.GetNewArrivals());
        }
    }
}
