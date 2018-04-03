using System.Collections.Generic;
using Newtonsoft.Json;

namespace DXANET
{
    public class DataElement
    {
        [JsonProperty("name")]
        public string name { get; set; }
        
        [JsonProperty("domain")]
        public string domain { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("definition")]
        public string definition { get; set; }
        
        [JsonProperty("guidance")]
        public string guidance { get; set; }
        
        [JsonProperty("identifier")]
        public string identifier { get; set; }
       
        [JsonProperty("usage")]
        public List<string> usage { get; set; }
        
        [JsonProperty("datatype")]
        public Datatype datatype { get; set; }
        
        [JsonProperty("values")]
        public List<object> values { get; set; }
        
        [JsonProperty("sourceURL")]
        public string sourceURL { get; set; }
    }
}
