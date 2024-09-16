using TravelManagementSystem.Domain.ValueObject;
using TravelManagementSystem.Shared.Abstraction.Domain;

namespace TravelManagementSystem.Domain.Entities
{
    public class TravelerCheckList : AggregateRoot<TravelerCheckListId>
    {
        public TravelerCheckListId Id { get; private set; }
        private TravelerCheckListName _name;
        private TravelerCheckListName _destination;

        private readonly LinkedList<Travelerltem> _list = new();


        public TravelerCheckList()
        {

        }

        internal TravelerCheckList(TravelerCheckListId id, TravelerCheckListName name, TravelerCheckListName destination)
        {
            Id = id;
            _name = name;
            _destination = destination;
        }

        private TravelerCheckList(TravelerCheckListId id, TravelerCheckListName name, TravelerCheckListName destination, LinkedList<Travelerltem> list) : this(id, name, destination)
        {
            _list = list;
        }
    }
}
