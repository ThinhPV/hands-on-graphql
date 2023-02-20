using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasteringGraphQL.Data.Entities
{
    public class Instrument
    {
        [Key]
        [Column("Id")]
        public int InstrumentId { get; set; }
        public string Ticker { get; set; }
        [Column("Name")]
        public string ShareName { get; set; }
        public short MarketID { get; set; }
        public int? MarCat { get; set; }
        public int? EurCat { get; set; }
        public int? ListID { get; set; }
        public string ISIN { get; set; }
        public string? CurrencyCode { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19,0)")]
        public decimal? NoShares { get; set; }
        //public decimal? MarketCap { get; set; }
        public DateTime? Agentupdate { get; set; }
        public string? MarketSpecSign { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Volatility { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Correlation { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? BetaFactor { get; set; }
        public byte? PrimaryMarket { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? EPS { get; set; }
        public double? SPS { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? DPS { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Turnover { get; set; }
        public decimal? TotalMarketCap { get; set; }
        public DateTime? LastRowChange { get; set; }
        public bool Visible { get; set; }
        public byte InstrumentType { get; set; }
        public bool? MainIndex { get; set; }
        public int? CompanyID { get; set; }
        public int? RegionID { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? MarketCapEUR { get; set; }
        public long? NumberOfUnlistedShares { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? VolumeTurnover { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? VolumeTurnoverUSD { get; set; }
        public int DataSourceID { get; set; }
        public string? WKN { get; set; }
        public string? RicCode { get; set; }

        //[GraphQLIgnore]
        public virtual InstrumentPrice InstrumentPrice { get; set; }

        //[GraphQLIgnore]
        public virtual Market Market { get; set; }

        //[GraphQLIgnore]
        //public virtual List<HistoricalData> HistoricalData { get; set; }

        //[GraphQLIgnore]
        //public virtual List<IntradayData> IntradayData { get; set; }

    }
}
