using Demo.Events;
using Demo.Models;
using Demo.Resolvers;
using Demo.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();

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
   .AddTypeExtension<BookExtensions>()
   .AddDirectiveType<MyDirectiveType>()
   .AddProjections()
   .AddFiltering()
   .AddSorting()
;

var app = builder.Build();

app.UseWebSockets();

app.MapGraphQL();

app.RunWithGraphQLCommandsAsync(args);

app.Run();
