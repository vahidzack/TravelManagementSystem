using TravelManagementSystem.Domain.ValueObject;

namespace TravelManagementSystem.Domain.Policies.Temperature
{
    internal sealed class LowTemperaturePolicy : ITravelerItemPolicy
    {
        public IEnumerable<TravelerItem> GenerateItems(PolicyData policyData) => new List<TravelerItem>
        {
            new("Winter Hat",1),
            new("Scarf",2),
            new("Gloves",2),
            new("Warm Jacket",1),
        };

        public bool IsApplicable(PolicyData policyData) => policyData.Temperature < 10D;
    }
}
