using Newtonsoft.Json;

namespace KobusBothaAPI.FronEnd.Model
{
    public class ResultItemTest
    {
        [JsonProperty("1M_pop")]
        public string Pop { get; set; }
        [JsonProperty("total")]
        public int? Total { get; set; }
    }
}
