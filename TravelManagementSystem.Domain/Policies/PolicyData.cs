using TravelManagementSystem.Domain.ValueObject;

namespace TravelManagementSystem.Domain.Policies
{
    public record PolicyData(TravelDays Days, Consts.Gender Gender, ValueObject.Temperature Temperature, Destination Destination);
}
