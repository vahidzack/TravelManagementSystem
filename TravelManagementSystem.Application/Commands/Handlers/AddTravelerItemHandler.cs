using TravelManagementSystem.Application.Exceptions;
using TravelManagementSystem.Domain.Repositories;
using TravelManagementSystem.Domain.ValueObject;
using TravelManagementSystem.Shared.Abstraction.Commands;

namespace TravelManagementSystem.Application.Commands.Handlers
{
    public sealed class AddTravelerItemHandler : ICommandHandler<AddTravelerItem>
    {
        private readonly ITravelerCheckListRepository _repository;

        public AddTravelerItemHandler(ITravelerCheckListRepository repository)
        {
            _repository = repository;
        }

        public async Task HandleAsync(AddTravelerItem command)
        {
            var travelerCheckList = await _repository.GetAsync(command.TravelerchecklistId);
            if (travelerCheckList is null)
            {
                throw new TravelerChecklistNotFound(command.TravelerchecklistId);
            }
            var travelerItem = new TravelerItem(command.Name, command.Quantity);
            travelerCheckList.AddItem(travelerItem);
            await _repository.UpdateAsync(travelerCheckList);
        }
    }
}
