using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasteringGraphQL.Data.Entities
{
    [Table("daily_history")]
    public class IntradayData
    {
        public long ID { get; set; }
        public int InstrumentID { get; set; }
        [Column(name: "hDate")]
        public DateTime Date { get; set; }
        [Column(name: "hClose", TypeName = "decimal(19,4)")]
        public decimal Close { get; set; }
        [Column(name: "hSize")]
        public long? Volume { get; set; }
    }
}
