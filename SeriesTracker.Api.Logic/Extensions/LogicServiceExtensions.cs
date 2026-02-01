using Microsoft.Extensions.DependencyInjection;

namespace SeriesTracker.Api.Logic.Extensions;

public static class LogicServiceExtensions
{
  public static IServiceCollection AddLogicProject(this IServiceCollection serviceCollection)
  {
    return serviceCollection;
  }
}
