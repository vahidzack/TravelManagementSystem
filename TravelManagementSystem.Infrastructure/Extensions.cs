using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Application.Services;
using TravelManagementSystem.Infrastructure.EF;
using TravelManagementSystem.Infrastructure.Logging;
using TravelManagementSystem.Shared.Abstraction.Commands;
using TravelManagementSystem.Shared.Queries;

namespace TravelManagementSystem.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSQLDB(configuration);
            services.AddQueries();
            services.AddSingleton<IWeatherService, WeatherService>();

            services.TryDecorate(typeof(ICommandHandler<>), typeof(LoggingCommandHandlerDecorator<>));

            return services;
        }
    }
}
