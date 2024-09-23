﻿using TravelManagementSystem.Domain.Entities;
using TravelManagementSystem.Domain.ValueObject;
using TravelManagementSystem.Shared.Abstraction.Domain;

namespace TravelManagementSystem.Domain.Events
{
    public record TravelerItemRemoved(TravelerCheckList TravelerCheckList, TravelerItem TravelerItem) : IDomainEvent
    {
    }
}
