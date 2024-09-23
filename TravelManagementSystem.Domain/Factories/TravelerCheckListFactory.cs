using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagementSystem.Domain.Consts;
using TravelManagementSystem.Domain.Entities;
using TravelManagementSystem.Domain.Policies;
using TravelManagementSystem.Domain.ValueObject;

namespace TravelManagementSystem.Domain.Factories
{
    public class TravelerCheckListFactory : ITravelerCheckListFactory
    {
        private readonly IEnumerable<ITravelerItemPolicy> _policies;

        public TravelerCheckListFactory(IEnumerable<ITravelerItemPolicy> policies) => _policies = policies;


        public TravelerCheckList Create(TravelerCheckListId id, TravelerCheckListName name, Destination destination) =>
        new(id, name, destination);
        public TravelerCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, TravelDays days, Gender gender, Temperature temperature, Destination destination)
        {
            var data = new PolicyData(days, gender, temperature, destination);
            var applicablePolicies = _policies.Where(p => p.IsApplicable(data));
            var items = applicablePolicies.SelectMany(p => p.GenerateItems(data));
            var travelerCheckingList = Create(id, name, destination);
            travelerCheckingList.AddItems(items);
            return travelerCheckingList;
        }
    }
}
