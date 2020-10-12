using Newtonsoft.Json;

namespace KobusBothaAPI.FronEnd.Model
{
    public class ResultItemCase : ResultItemDeath
    {
        [JsonProperty("active")]
        public int? Active { get; set; }
        [JsonProperty("critical")]
        public int? Critical { get; set; }
        [JsonProperty("recovered")]
        public int? Recovered { get; set; }
    }
}
