namespace KobusBothaAPI.FronEnd.Model
{
    /// <summary>
    /// Will be used to display total and percentage total vs X
    /// </summary>
    public class SummaryBasic
    {
        public int Total { get; set; }
        public decimal Percentage { get; set; } = 0;
    }
}
