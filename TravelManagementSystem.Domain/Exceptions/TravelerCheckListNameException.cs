using TravelManagementSystem.Shared.Abstraction.Exceptions;

namespace TravelManagementSystem.Domain.Exceptions
{
    public class TravelerCheckListNameException : TravelerCheckListExceptions
    {
        public TravelerCheckListNameException() : base("Travel Check list Name Can not be null!!")
        {
        }
    }
}
