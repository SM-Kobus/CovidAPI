using KobusBothaAPI.FronEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KobusBothaAPI.FronEnd.Common
{
    public class MyCommon
    {
        public static IEnumerable<SummaryItem> GetItemList(ResultItemList result, SummaryType type)
        {
            List<SummaryItem> list = new List<SummaryItem>();
            if (result != null)
            {
                var allList = result.Response.Where(x => x.Continent != null && x.Country != null);
                var names = type == SummaryType.Continent ? allList.Select(x => x.Continent).Distinct() : allList.Select(x => x.Country);
                // Get total Cases
                var totalCases = allList.Sum(x => x.Cases.Total ?? 0);
                // Get Total Active cases
                var totalActive = allList.Sum(x => x.Cases.Active ?? 0);
                // Get Total deaths
                var totalDeaths = allList.Sum(x => x.Deaths.Total ?? 0);
                // Get Total tests
                var totalTests = allList.Sum(x => x.Tests.Total ?? 0);
                // Declaring variables outside loop
                SummaryCase summaryCase;
                SummaryBasic summaryDeath;
                SummaryBasic summaryTest;
                int total;
                foreach (var name in names)
                {
                    var selList = type == SummaryType.Continent ? allList.Where(x => x.Continent == name) : allList.Where(x => x.Country == name);
                    summaryCase = new SummaryCase();
                    summaryDeath = new SummaryBasic();
                    summaryTest = new SummaryBasic();
                    SummaryItem item = new SummaryItem()
                    {
                        Name = name,
                        Cases = new SummaryCase()
                        {
                            TotalNew = selList.Sum(x => x.Cases.NewResult),
                            TotalActive = selList.Sum(x => x.Cases.Active ?? 0)
                        },
                        Deaths = new SummaryBasic()
                        {
                            Total = selList.Sum(x => x.Deaths.Total ?? 0)
                        },
                        Tests = new SummaryBasic()
                        {
                            Total = selList.Sum(x => x.Tests.Total ?? 0)
                        }
                    };

                    if (totalActive != 0) item.Cases.PercentageActive = Math.Round(Convert.ToDecimal(item.Cases.TotalActive) / Convert.ToDecimal(totalActive) * 100, 2);
                    total = selList.Sum(x => x.Cases.Total ?? 0);
                    if (totalCases != 0) item.Cases.PercentageTotal = Math.Round(Convert.ToDecimal(total) / Convert.ToDecimal(totalCases) * 100, 2);
                    if (totalDeaths != 0) item.Deaths.Percentage = Math.Round(Convert.ToDecimal(item.Deaths.Total) / Convert.ToDecimal(totalDeaths) * 100, 2);
                    if (totalTests != 0) item.Tests.Percentage = Math.Round(Convert.ToDecimal(item.Tests.Total) / Convert.ToDecimal(totalTests) * 100, 2);
                    list.Add(item);
                }
            }
            return list;
        }
    }

    public enum SummaryType
    {
        Continent,
        Country
    }
}
