using Newtonsoft.Json;
using System.Collections.Generic;

namespace KobusBothaAPI.FronEnd.Model
{
    public class ResultItemList
    {
        [JsonProperty("response")]
        public IEnumerable<ResultItem> Response { get; set; }
    }
}
