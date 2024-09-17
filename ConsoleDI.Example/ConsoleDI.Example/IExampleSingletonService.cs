using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI.Example
{
    public interface IExampleSingletonService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime => ServiceLifetime.Singleton;
    }
}