using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI.Example
{
    public interface IExampleScopedService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime => ServiceLifetime.Scoped;
    }
}