using Microsoft.Extensions.DependencyInjection;

namespace SeriesTracker.Api.Data.Extensions;

public static class DataServiceExtensions
{
  public static IServiceCollection AddDataProject(this IServiceCollection serviceCollection)
  {
    return serviceCollection;
  }
}
