namespace KobusBothaAPI.FronEnd.Model
{
    public class SummaryItem
    {
        public string Name { get; set; }
        public SummaryCase Cases { get; set; }
        public SummaryBasic Deaths { get; set; }
        public SummaryBasic Tests { get; set; }
    }
}
