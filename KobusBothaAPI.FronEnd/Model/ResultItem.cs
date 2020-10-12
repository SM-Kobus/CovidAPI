using Newtonsoft.Json;

namespace KobusBothaAPI.FronEnd.Model
{
    public class ResultItem
    {  
        [JsonProperty("continent")]
        public string Continent { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("population")]
        public long? Population { get; set; }
        [JsonProperty("cases")]
        public ResultItemCase Cases { get; set; }
        [JsonProperty("deaths")]
        public ResultItemDeath Deaths { get; set; }
        [JsonProperty("tests")]
        public ResultItemTest Tests { get; set; }
    }
}
