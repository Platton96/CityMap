using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Collections.Generic;
namespace MyCityMap.Models
{   [DataContract]
    public class DataFromJason
    {  [DataMember (Name ="photos")]
       IEnumerable<City> Cities { get; set; }
    }
}
