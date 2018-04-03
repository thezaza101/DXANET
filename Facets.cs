using Newtonsoft.Json;

namespace DXANET
{
    public class Facets
    {
        [JsonProperty("pattern")]
        public string pattern { get; set; }

        [JsonProperty("maxLength")]
        public string maxLength { get; set; }

        [JsonProperty("minInclusive")]
        public string minInclusive { get; set; }

        [JsonProperty("minLength")]
        public string minLength { get; set; }
    }
}
