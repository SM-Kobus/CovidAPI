using KobusBothaAPI.FronEnd.Model;
using KobusBothaAPI.FronEnd.Common;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace KobusBothaAPI.FronEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContinentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<SummaryItem> Get()
        {
            var client = new RestClient("https://covid-193.p.rapidapi.com/statistics");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "covid-193.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "6a4be85e2dmsh3d8ef37952aa619p1163c7jsnac4b96463eea");
            IRestResponse response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResultItemList>(response.Content);
            return MyCommon.GetItemList(result, SummaryType.Continent);
        }
    }
}
