using TravelManagementSystem.Domain.Events;
using TravelManagementSystem.Domain.Exceptions;
using TravelManagementSystem.Domain.ValueObject;
using TravelManagementSystem.Shared.Abstraction.Domain;

namespace TravelManagementSystem.Domain.Entities
{
    public class TravelerCheckList : AggregateRoot<TravelerCheckListId>
    {
        public TravelerCheckListId Id { get; private set; }
        private TravelerCheckListName _name;
        private Destination _destination;

        private readonly LinkedList<TravelerItem> _list = new();


        public TravelerCheckList()
        {

        }

        internal TravelerCheckList(TravelerCheckListId id, TravelerCheckListName name, Destination destination)
        {
            Id = id;
            _name = name;
            _destination = destination;
        }

        private TravelerCheckList(TravelerCheckListId id, TravelerCheckListName name, Destination destination, LinkedList<TravelerItem> list) : this(id, name, destination)
        {
            _list = list;
        }

        public void AddItem(TravelerItem item)
        {
            var alreadyExist = _list.Any(l => l.Name == item.Name);
            if (alreadyExist)
            {
                throw new TravelerItemAlreadyExistException(_name, item.Name);
            }
            _list.AddLast(item);
            AddEvent(new TravelerItemAdded(this, item));
        }

        public void AddItems(IEnumerable<TravelerItem> items)
        {
            foreach (var item in items)
            {
                AddItem(item);
            }
        }

        public void TakeItem(string itemName)
        {
            var item = GetItem(itemName);
            var TravelerItem = item with { IsTaken = true };
            _list.Find(item).Value = TravelerItem;
            AddEvent(new TravelerItemTaken(this, item));

        }
        public void RemoveItem(string itemName)
        {
            var item = GetItem(itemName);
            _list.Remove(item);
            AddEvent(new TravelerItemRemoved(this, item));

        }



        private TravelerItem GetItem(string itemName)
        {
            var item = _list.SingleOrDefault(l => l.Name == itemName);
            if (item == null) throw new TravelerItemNotFoundException(itemName);
            return item;
        }
    }
}
