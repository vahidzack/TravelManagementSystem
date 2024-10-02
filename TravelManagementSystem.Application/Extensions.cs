using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Domain.Factories;
using TravelManagementSystem.Domain.Policies;
using TravelManagementSystem.Shared.Commands;

namespace TravelManagementSystem.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddCommands();
            services.AddSingleton<ITravelerCheckListFactory, TravelerCheckListFactory>();

            services.Scan(b => b.FromAssemblies(typeof(ITravelerItemPolicy).Assembly)
                .AddClasses(c => c.AssignableTo<ITravelerItemPolicy>())
                .AsImplementedInterfaces()
                .WithSingletonLifetime());

            return services;
        }
    }
}
