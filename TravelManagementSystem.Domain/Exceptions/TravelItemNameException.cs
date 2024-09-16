using TravelManagementSystem.Shared.Abstraction.Exceptions;

namespace TravelManagementSystem.Domain.Exceptions
{
    public class TravelItemNameException : TravelerCheckListExceptions
    {
        public TravelItemNameException() : base("travel Item Name Can not Be empty !!")
        {
        }
    }
}
