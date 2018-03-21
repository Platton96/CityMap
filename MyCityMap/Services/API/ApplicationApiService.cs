using System;
using System.Threading.Tasks;
using MyCityMap.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace MyCityMap.Services.API
{
    public class ApplicationApiService
    {
        private const string DataUrl = "https://api.myjson.com/bins/7ybe5";

        public async Task<DataFromJason> FetchDataAsync()
        {
            var httpClient = new HttpClient();
            var dataUri = new Uri(DataUrl);
            var result = new DataFromJason();
            //var responce = await httpClient.GetStringAsync(dataUri);
            //result = JsonConvert.DeserializeObject<DataFromJason>(responce);
            try
            {
                var responce = await httpClient.GetStringAsync(dataUri);
                result = JsonConvert.DeserializeObject<DataFromJason>(responce);
            }
            catch
            {
                //throw new Exception();
            }
            httpClient.Dispose();
            return result;
        }
    }
}
