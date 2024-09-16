using TravelManagementSystem.Domain.Exceptions;

namespace TravelManagementSystem.Domain.ValueObject
{
    public record TravelerCheckListName
    {
        public string Value { get; }

        public TravelerCheckListName(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new TravelerCheckListNameException();
            Value = value.Trim();
        }

        public static implicit operator string(TravelerCheckListName name) => name.Value;
        public static implicit operator TravelerCheckListName(string name) => new(name);
    }
}
