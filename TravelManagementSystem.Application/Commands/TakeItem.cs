using TravelManagementSystem.Shared.Abstraction.Commands;

namespace TravelManagementSystem.Application.Commands
{
    public record TakeItem(Guid TravelerCheckListId, string Name) : ICommand;
}
