using System.Collections.Generic;
using Newtonsoft.Json;

namespace DXANET
{
    public class Domain
    {
        [JsonProperty("domain")]
        public string domain { get; set; }
        
        [JsonProperty("acronym")]
        public string acronym { get; set; }

        [JsonProperty("version")]
        public string version { get; set; }
        
        [JsonProperty("sourceURL")]
        public string rootSourceURL { get; set; }

        [JsonProperty("content")]
        public List<DataElement> content { get; set; }

        public List<DictElement> ToDictElementList()
        {
            List<DictElement> listElements = new List<DictElement>();
            content.ForEach(de => {listElements.Add(new DictElement(){domainAcronym=acronym, elementName=de.name}); });
            return listElements;
        }
    }
}
