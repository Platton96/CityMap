using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Collections.Generic;
namespace MyCityMap.Models
{   [DataContract]
    public class DataFromJason
    {
        [JsonProperty]
        [DataMember (Name ="photos")]
       public IEnumerable<City> Cities { get; set; }
    }
}
