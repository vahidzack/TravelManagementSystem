using TravelManagementSystem.Shared.Abstraction.Commands;

namespace TravelManagementSystem.Application.Commands
{
    public record RemoveTravelerCheckList(Guid Id) : ICommand;
}
