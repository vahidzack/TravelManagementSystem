using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Domain.Exceptions;
using TravelManagementSystem.Shared.Abstraction.Exceptions;

namespace TravelManagementSystem.Domain.ValueObject
{
    public record TravelerCheckListId
    {
        public Guid Value { get; }
        public TravelerCheckListId(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new TravelerCheckListIdException();
            }
            Value = value;
        }
        public static implicit operator Guid(TravelerCheckListId id) => id.Value;
        public static implicit operator TravelerCheckListId(Guid id) => new(id);
    }
}
