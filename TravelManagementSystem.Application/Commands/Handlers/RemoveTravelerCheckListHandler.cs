using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Application.Exceptions;
using TravelManagementSystem.Domain.Events;
using TravelManagementSystem.Domain.Repositories;
using TravelManagementSystem.Shared.Abstraction.Commands;

namespace TravelManagementSystem.Application.Commands.Handlers
{
    public sealed class RemoveTravelerCheckListHandler : ICommandHandler<RemoveTravelerCheckList>
    {
        private readonly ITravelerCheckListRepository _Repository;

        public RemoveTravelerCheckListHandler(ITravelerCheckListRepository repository) => _Repository = repository;

        public async Task HandleAsync(RemoveTravelerCheckList command)
        {
            var travelerCheckList = await _Repository.GetAsync(command.Id);
            if (travelerCheckList is null)
            {
                throw new TravelerChecklistNotFound(command.Id);
            }
            await _Repository.DeleteAsync(travelerCheckList);
        }
    }
}
