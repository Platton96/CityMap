using Newtonsoft.Json;
using System.Runtime.Serialization;
namespace MyCityMap.Models
{
    [DataContract]
    public class City
    {
        [JsonProperty]
        [DataMember (Name = "id")]
        public int Id { get; set; }
        [JsonProperty]
        [DataMember (Name = "title")]
        public string Name { get; set; }
        [JsonProperty]
        [DataMember (Name = "description")]
        public string Description { get; set; }
        [JsonProperty]
        [DataMember (Name = "url")]
        public string ImageUrl { get; set; }
    }
}
