using Demo.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services.
    AddGraphQLServer()
   .AddMutationConventions(applyToAllMutations: true)
   .AddQueryType<Query>()
   .AddMutationType<Mutation>()
;

var app = builder.Build();

app.MapGraphQL();

app.Run();
