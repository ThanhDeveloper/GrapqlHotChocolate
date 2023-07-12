using Demo.Events;
using Demo.Models;
using Demo.Resolvers;
using Demo.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services.
    AddGraphQLServer()
   .AddMutationConventions()
   .AddQueryType<Query>()
   .AddMutationType<Mutation>()
   .AddDiagnosticEventListener<MyExecutionEventListener>()
   .AddSubscriptionType<Subcription>()
   .AddInMemorySubscriptions()
   .AddType<TextMessage>()
   .AddType<TextContent>()
   .AddType<ImageContent>()
   .AddTypeExtension<QueryBookResolvers>()
;

var app = builder.Build();

app.UseWebSockets();

app.MapGraphQL();

app.Run();
