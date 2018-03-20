using System;
using Newtonsoft.Json;
using System.Threading.Tasks;
using MyCityMap.Models;
using Windows.Storage;

namespace MyCityMap.Infrastructure
{
    public class LocalStorage
    {
        private const string DataFileName = "data.txt";
        private StorageFolder _localStorage;

        public LocalStorage()
        {
            _localStorage = Windows.Storage.ApplicationData.Current.LocalFolder;
        }

        public async Task SaveDate(DataFromJason data)
        {
            var dataFile =await _localStorage.CreateFileAsync(DataFileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(dataFile, JsonConvert.SerializeObject(data));
        }

        public async Task<DataFromJason> GetData()
        {
            try
            {
                var dataFile = await _localStorage.GetFileAsync(DataFileName);
                var saveData = await FileIO.ReadTextAsync(dataFile);

                return JsonConvert.DeserializeObject<DataFromJason>(saveData);
            }
            catch (Exception)
            {

                return new DataFromJason();
            }
        }
    }
}
