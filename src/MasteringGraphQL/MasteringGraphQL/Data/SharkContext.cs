using MasteringGraphQL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;

namespace MasteringGraphQL.Data
{
    public class SharkContext : DbContext
    {
        public SharkContext(DbContextOptions<SharkContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Market>()
                .HasOne(i => i.Instrument)
                .WithOne(m => m.Market)
                .HasForeignKey<Instrument>(i => i.MarketID);

        }

        public virtual DbSet<Instrument> Instrument { get; set; }
        public virtual DbSet<InstrumentPrice> InstrumentPrice { get; set; }
        public virtual DbSet<Market> Market { get; set; }
        public virtual DbSet<IntradayData> IntradayData { get; set; } // from table: 'daily_history'


        //public virtual DbSet<IntradayData> IntradayData { get; set; } // from table: 'daily_history'
        //public virtual DbSet<IntradayData> AggregatedIntradayData { get; set; } // from stored procedures: 'SGH3_GetDailyHistoryForGraph'
        //public virtual DbSet<HistoricalData> HistoricalData { get; set; } // from view: 'instrumentHistory'


        [DbFunction("fn_shgGetMarketStatus", "dbo")] // new-scalarFunc
        public static int GetMarketStatus(short marketId, int checkNextDay)
            => throw new NotSupportedException();

        [DbFunction("fnGetRelativeVolume", "dbo")] // new-scalarFunc
        public static decimal? GetVolumeChange(int instrumentId, int dayPeriod)
            => throw new NotSupportedException();

        [DbFunction("fnGetTotalTrades", "dbo")] // new-scalarFunc
        public static int? GetTotalTrades(int instrumentId, DateTime ipDateCet)
            => throw new NotSupportedException();

        [DbFunction("fnSSSelectSubSector", "dbo")]
        public static string GetIndustry(int marCat, short market, int lang)
            => throw new NotSupportedException();

        [DbFunction("fnSSSelectSectorNewSubSectors", "dbo")]
        public static int? GetIndustryTranslationID(int eurCat, int lang)
            => throw new NotSupportedException();

        [DbFunction("fn_shgGetRateForCurrencyExchange", "dbo")]
        public static int? GetRateForCurrencyExchange(string currencyBase, string currencyQuote, DateTime date)
            => throw new NotSupportedException();

        [DbFunction("fn_shgGetPeriodChange", "dbo")]
        public static decimal GetPeriodChange(int instrumentId, DateTime startDate)
            => throw new NotSupportedException();

        [DbFunction("fnGetStartingDate", "dbo")]
        public static DateTime? GetStartingDate(int instrumentId)
            => throw new NotSupportedException();
    }
}
