using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Domain.Repositories;
using TravelManagementSystem.Infrastructure.EF.Contexts;
using TravelManagementSystem.Infrastructure.EF.Option;
using TravelManagementSystem.Infrastructure.EF.Repositories;
using TravelManagementSystem.Infrastructure.EF.Services;
using TravelManagementSystem.Shared.Options;

namespace TravelManagementSystem.Infrastructure.EF
{
    internal static class Extensions
    {
        public static IServiceCollection AddSQLDB(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ITravelerCheckListRepository, TravelerCheckListRepository>();
            services.AddScoped<TravelerCheckReadService, TravelerCheckReadService>();

            var options = configuration.GetOptions<DataBaseOption>("DataBaseConnectionString");
            services.AddDbContext<ReadDBContext>(ctx =>
            ctx.UseSqlServer(options.ConnectionString));
            services.AddDbContext<WriteDBContext>(ctx => 
                ctx.UseSqlServer(options.ConnectionString));

            return services;
        }
    }
}
