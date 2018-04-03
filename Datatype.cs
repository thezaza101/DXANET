using System.Collections.Generic;
using Newtonsoft.Json;

namespace DXANET
{
    public class Datatype
    {
        [JsonProperty("facets")]
        public Facets facets { get; set; }
        
        [JsonProperty("type")]
        public string type { get; set; }
        
        [JsonProperty("values")]
        public List<string> values { get; set; }
    }
}
