using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Domain.ValueObject;
using TravelManagementSystem.Shared.Abstraction.Exceptions;

namespace TravelManagementSystem.Application.Exceptions
{
    public class MissingDestinationWeatherException : TravelerCheckListExceptions
    {
        public Destination Destination { get; }
        public MissingDestinationWeatherException(Destination destination) : base($"Could not Fetch Weathe Data From '{destination.Country}/{destination.City}'")
        {
            Destination = destination;
        }
    }
}
