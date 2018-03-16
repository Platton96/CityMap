using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCityMap.Services.API;
using MyCityMap.Models;

namespace MyCityMap.Services
{
    public class CityService
    {
        private readonly ApplicationApiService _applicationApiService;

        public CityService()
        {
            _applicationApiService = new ApplicationApiService();
        }

        public async Task<IEnumerable<City>> LoadCityAsync()
        {
            var data = await _applicationApiService.FetchDataAsync();
            return data.Cities;
               
        }
    }
}
