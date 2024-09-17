using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI.Example
{
    internal sealed class ExampleScopedService:IExampleScopedService
    {
        public ServiceLifetime Lifetime => throw new NotImplementedException();

        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    }
}
