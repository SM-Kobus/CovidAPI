namespace KobusBothaAPI.FronEnd.Model
{
    public class SummaryCase
    {
        #region Constructors
        public SummaryCase()
        {

        }
        #endregion Constructors

        public int TotalNew { get; set; }
        public int TotalActive { get; set; }
        public decimal PercentageTotal { get; set; } = 0;
        public decimal PercentageActive { get; set; } = 0;
    }
}
