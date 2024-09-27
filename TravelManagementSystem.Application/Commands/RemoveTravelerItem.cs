using TravelManagementSystem.Shared.Abstraction.Commands;

namespace TravelManagementSystem.Application.Commands
{
    public record RemoveTravelerItem(Guid TravelerChecklistId,string Name) : ICommand
    {
    }
}
