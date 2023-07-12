using HotChocolate.Execution.Instrumentation;
using HotChocolate.Execution;
using HotChocolate.Resolvers;
using HotChocolate.Execution.Processing;

namespace Demo.Events
{
    public class MyExecutionEventListener : ExecutionDiagnosticEventListener
    {
        private readonly ILogger<MyExecutionEventListener> _logger;

        public MyExecutionEventListener(ILogger<MyExecutionEventListener> logger)
            => _logger = logger;

        public override void RequestError(IRequestContext context,
            Exception exception)
        {
            _logger.LogError(exception, "A request error occurred!");
        }

        public override IDisposable ExecuteRequest(IRequestContext context)
        {
            var start = DateTime.UtcNow;

            return new RequestScope(start, _logger);
        }

        public override void ResolverError(IMiddlewareContext context, IError error)
        {
            Console.WriteLine(error.ToString());
        }

        public override void ResolverError(IRequestContext context, ISelection selection, IError error)
        {
            Console.WriteLine(error.ToString());
        }
        

        public override void TaskError(IExecutionTask task, IError error)
        {
            Console.WriteLine(error.ToString());
        }
    }

    public class RequestScope : IDisposable
    {
        private readonly ILogger _logger;
        private readonly DateTime _start;

        public RequestScope(DateTime start, ILogger logger)
        {
            _start = start;
            _logger = logger;
        }

        // this is invoked at the end of the `ExecuteRequest` operation
        public void Dispose()
        {
            var end = DateTime.UtcNow;
            var elapsed = end - _start;

            _logger.LogInformation("Request finished after {Ticks} ticks",
                elapsed.Ticks);
        }
    }
}
