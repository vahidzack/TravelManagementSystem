using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Shared.Abstraction.Exceptions;

namespace TravelManagementSystem.Domain.Exceptions
{
    public class TravelerItemNotFoundException : TravelerCheckListExceptions
    {
        public string ItemName { get; }
        public TravelerItemNotFoundException(string itemName) : base($"Traveler {itemName} Not Found  ")
        {
            ItemName = itemName;
        }
    }
}
