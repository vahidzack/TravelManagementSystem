using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Application.Exceptions;
using TravelManagementSystem.Domain.Repositories;
using TravelManagementSystem.Shared.Abstraction.Commands;

namespace TravelManagementSystem.Application.Commands.Handlers
{
    public sealed class RemoveTravelerItemHandler : ICommandHandler<RemoveTravelerItem>
    {
        private readonly ITravelerCheckListRepository _Repository;

        public RemoveTravelerItemHandler(ITravelerCheckListRepository repository) => _Repository = repository;

        public async Task HandleAsync(RemoveTravelerItem command)
        {
            var travelerCheckList = await _Repository.GetAsync(command.TravelerChecklistId);
            if (travelerCheckList is null)
            {
                throw new TravelerChecklistNotFound(command.TravelerChecklistId);
            }
            travelerCheckList.RemoveItem(command.Name);
            await _Repository.UpdateAsync(travelerCheckList);
        }
    }
}
