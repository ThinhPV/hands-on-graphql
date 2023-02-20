using MasteringGraphQL.Data;
using System.Globalization;

namespace MasteringGraphQL.GraphQL.Queries
{
    [QueryType]
    public static class InstrumentQueries
    {
        public static int GetInstrument() => 1;


        //[UseProjection]
        //public static IQueryable<Instrument> GetInstrument(
        //    SharkContext dbContext,
        //    int instrumentId,
        //    int dayPeriod = 10)
        //{
        //    var langCode = CultureInfo.CurrentCulture.Name;

        //    return dbContext.Instrument
        //        .AsNoTracking()
        //        .Include(i => i.InstrumentPrice)
        //        .Include(i => i.Market)
        //        .Include(i => i.Currency)
        //        .Include(i => i.List)
        //        .Where(i => i.InstrumentId == instrumentId);
        //    //.ToInstrumentDTOs(dayPeriod, langCode);
        //}
    }
}
