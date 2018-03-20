using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCityMap.Services.API;
using MyCityMap.Models;
using MyCityMap.Infrastructure;

namespace MyCityMap.Services
{
    public class CityService
    {
        private readonly ApplicationApiService _applicationApiService;
        private readonly LocalStorage _localStorage;

        public CityService()
        {
            _applicationApiService = new ApplicationApiService();
            _localStorage = new LocalStorage();
        }

        public async Task<IEnumerable<City>> LoadCityAsync()
        {
            var data = await _applicationApiService.FetchDataAsync();

            if (data != null) await _localStorage.SaveDate(data);
            else data = await _localStorage.GetData();
         
            return data.Cities;
               
        }
    }
}
