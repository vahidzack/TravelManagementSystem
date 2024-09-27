using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Shared.Abstraction.Exceptions;

namespace TravelManagementSystem.Application.Exceptions
{
    public class TravelerChecklistNotFound : TravelerCheckListExceptions
    {

        public Guid Id { get; }

        public TravelerChecklistNotFound(Guid id) : base($"Traveler CheckList with ID '{id}' was not Found") =>
            Id = id;
    }

}
