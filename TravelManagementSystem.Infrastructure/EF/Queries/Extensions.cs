
using TravelManagementSystem.Application.DTO;
using TravelManagementSystem.Infrastructure.EF.Models;

namespace TravelManagementSystem.Infrastructure.EF.Queries
{
    internal static class Extensions
    {
        public static TravelerCheckListDTO AsDto(this TravelerCheckListReadModel readModel)
            => new()
            {
                Id = readModel.Id,
                Name = readModel.Name,
                Destination = new DestinationDTO
                {
                    City = readModel.Destination?.City,
                    Country = readModel.Destination?.Country
                },
                Items = readModel.Items?.Select(pi => new TravelerItemDTO
                {
                    Name = pi.Name,
                    Quantity = pi.Quantity,
                    IsTaken = pi.IsTaken,
                })
            };
    }
}
