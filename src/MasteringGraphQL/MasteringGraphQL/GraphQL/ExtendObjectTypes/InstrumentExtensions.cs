using HotChocolate.Resolvers;
using MasteringGraphQL.Data;
using MasteringGraphQL.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MasteringGraphQL.GraphQL.ExtendObjectTypes
{
    [ExtendObjectType(typeof(DTOs.InstrumentInfo))]
    public class InstrumentExtensions
    {
        public IQueryable<IntradayData> GetIntradayData(
            SharkContext context,
            IResolverContext resolver,
            [Service] IHttpContextAccessor httpContextAccessor,
            string period = "1m",
            DateTime? fromDate = null,
            DateTime? toDate = null)
        {
            var canGetVariable = resolver.Variables.TryGetVariable("id", out int instrumentId);

            // just for testing...
            return context.IntradayData.AsNoTracking()
                .Where(i => i.InstrumentID == instrumentId && i.Date > DateTime.Now.AddDays(-5));
        }
    }
}
