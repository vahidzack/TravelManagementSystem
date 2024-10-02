using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Shared.Abstraction.Commands;

namespace TravelManagementSystem.Shared.Commands
{
    internal sealed class InMemoryCommandDispatcher : ICommandDispatcher
    {
        private readonly IServiceProvider _serviceProvider;

        public InMemoryCommandDispatcher(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;

        public async Task DispatchAsync<TCommand>(TCommand command) where TCommand : class, ICommand
        {
            using var scope = _serviceProvider.CreateScope();
            var handler = scope.ServiceProvider.GetRequiredService<ICommandHandler<TCommand>>();
            await handler.HandleAsync(command);
        }
    }
}
