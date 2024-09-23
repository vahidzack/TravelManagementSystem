using TravelManagementSystem.Domain.Consts;
using TravelManagementSystem.Domain.Entities;
using TravelManagementSystem.Domain.ValueObject;

namespace TravelManagementSystem.Domain.Factories
{
    public interface ITravelerCheckListFactory
    {
        TravelerCheckList Create(TravelerCheckListId id, TravelerCheckListName name, Destination destination);
        TravelerCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, TravelDays days, Gender gender,
            Temperature temperature, Destination destination);
    }
}
