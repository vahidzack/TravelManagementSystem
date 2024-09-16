using TravelManagementSystem.Shared.Abstraction.Exceptions;

namespace TravelManagementSystem.Domain.Exceptions
{
    public class TravelerCheckListIdException : TravelerCheckListExceptions
    {
        public TravelerCheckListIdException() : base("Traveler CheckList Id Can Not be Null !!")
        {
        }
    }
}
