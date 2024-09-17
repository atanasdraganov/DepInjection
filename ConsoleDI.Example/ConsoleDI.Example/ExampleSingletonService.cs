using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI.Example
{
    internal sealed class ExampleSingletonService:IExampleSingletonService
    {
        public ServiceLifetime Lifetime => throw new NotImplementedException();

        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    }
}
