using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace KobusBothaAPI.FronEnd.Model
{
    public class ResultItemDeath : ResultItemTest
    {
        [JsonProperty("new")]
        public string New { get; set; }
        // To extract int from string
        public int NewResult
        {
            get
            {
                int r = 0;
                if(!string.IsNullOrEmpty(New))
                {
                    var data = Regex.Match(New, @"\d+").Value;
                    int.TryParse(data, out r);
                }                
                return r;
            }
        }
    }
}
