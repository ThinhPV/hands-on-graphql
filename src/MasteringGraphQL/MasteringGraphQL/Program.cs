using MasteringGraphQL.Data;
using MasteringGraphQL.GraphQL.ExtendObjectTypes;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SharkContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("SharkDb")));

builder.Services
    .AddGraphQLServer()
    .AddTypes()
    .AddTypeExtension<InstrumentExtensions>()
    .RegisterDbContext<SharkContext>(DbContextKind.Resolver)
    .AddProjections();


var app = builder.Build();

app.MapGraphQL();

app.Run();
