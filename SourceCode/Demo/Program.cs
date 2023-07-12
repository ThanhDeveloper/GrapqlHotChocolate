using Demo.Events;
using Demo.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services.
    AddGraphQLServer()
   .AddMutationConventions()
   .AddQueryType<Query>()
   .AddMutationType<Mutation>()
   .AddDiagnosticEventListener<MyExecutionEventListener>()
;

var app = builder.Build();

app.MapGraphQL();

app.Run();
