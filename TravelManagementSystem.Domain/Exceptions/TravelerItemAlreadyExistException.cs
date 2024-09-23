using TravelManagementSystem.Shared.Abstraction.Exceptions;

namespace TravelManagementSystem.Domain.Exceptions
{
    public class TravelerItemAlreadyExistException : TravelerCheckListExceptions
    {
        public string ListName { get; }
        public string ItemName { get; }
        public TravelerItemAlreadyExistException(string listName, string itemName) :
            base($"Traveler check list '{listName}'already define item '{itemName}'")
        {
            ListName = listName;
            ItemName = itemName;
        }
    }
}
