using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MasteringGraphQL.Data.Entities
{
    public class InstrumentPrice
    {
        [Key]
        public int InstrumentId { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Bid { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Ask { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Open { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Last { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? High { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Low { get; set; }
        public long? Volume { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Mid { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? PrevClose { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Change { get; set; }
        public DateTime? LastRowChange { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? ChangePercentage { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? TodayTurnover { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? VWAP { get; set; }
        public int? BidSize { get; set; }
        public int? AskSize { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? OfficialClose { get; set; }
        public DateTime? OfficialCloseDate { get; set; }
        [Column("Date")]
        public DateTime? LastUpdatedDate { get; set; }
    }
}
