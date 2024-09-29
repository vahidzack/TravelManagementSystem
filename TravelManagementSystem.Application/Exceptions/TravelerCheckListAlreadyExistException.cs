using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Shared.Abstraction.Exceptions;

namespace TravelManagementSystem.Application.Exceptions
{
    public class TravelerCheckListAlreadyExistException :TravelerCheckListExceptions
    {
        public string  Name { get; set; }


        public TravelerCheckListAlreadyExistException(string name) : base($"Traveler check List with name '{name}' Already Exist")
        {
            Name = name;
        }
    }
}
