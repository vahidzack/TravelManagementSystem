using TravelManagementSystem.Domain.Consts;
using TravelManagementSystem.Shared.Abstraction.Commands;


namespace TravelManagementSystem.Application.Commands
{
    public record CreateTravelerCheckListWithItems(Guid Id, string Name, ushort Days, Gender Gender,
        DestinationWriteModel Destination) :ICommand;

    public record DestinationWriteModel(string City, string Country);
}
