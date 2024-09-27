using TravelManagementSystem.Shared.Abstraction.Commands;

namespace TravelManagementSystem.Application.Commands
{
    public record AddTravelerItem(Guid TravelerchecklistId, string Name, uint Quantity) : ICommand;
}
