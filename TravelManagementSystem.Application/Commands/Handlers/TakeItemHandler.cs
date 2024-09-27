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
    public sealed class TakeItemHandler : ICommandHandler<TakeItem>
    {
        private readonly ITravelerCheckListRepository _Repository;

        public TakeItemHandler(ITravelerCheckListRepository repository) => _Repository = repository;

        public async Task HandleAsync(TakeItem command)
        {
            var travelerChekList = await _Repository.GetAsync(command.TravelerCheckListId);
            if (travelerChekList is null)
            {
                throw new TravelerChecklistNotFound(command.TravelerCheckListId);
            }
            travelerChekList.TakeItem(command.Name);
            await _Repository.UpdateAsync(travelerChekList);
        }
    }
}
