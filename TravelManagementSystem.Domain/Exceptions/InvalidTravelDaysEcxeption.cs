using TravelManagementSystem.Shared.Abstraction.Exceptions;

namespace TravelManagementSystem.Domain.Exceptions
{
    public class InvalidTravelDaysEcxeption : TravelerCheckListExceptions
    {
        public ushort Days { get; set; }
        public InvalidTravelDaysEcxeption(ushort days) : base($"Value '{days}' is invalid TravelerList") => Days = days;
    }
}
