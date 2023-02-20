using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MasteringGraphQL.Data.Entities
{
    public class Market
    {
        [Key]
        public short MarketNumber { get; set; }
        [Column("Abbreviation")]
        public string? MarketAbbreviation { get; set; }
        public string? MarketOpenTimeLocal { get; set; }
        public string? MarketCloseTimeLocal { get; set; }
        public short TimeDiff { get; set; }
        public string? DataSource { get; set; }
        public string? Delay { get; set; }
        public string TimeZone { get; set; }
        public int TimezoneID { get; set; }
        public bool BusinessDaysStoT { get; set; }
        public int TranslationId { get; set; }
        public int CityId { get; set; }

        [GraphQLIgnore]
        public Instrument Instrument { get; set; }
    }
}
