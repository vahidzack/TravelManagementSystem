using TravelManagementSystem.Domain.ValueObject;

namespace TravelManagementSystem.Domain.Policies.Temperature
{
    internal sealed class HighTemperaturePolicy : ITravelerItemPolicy
    {
        public IEnumerable<TravelerItem> GenerateItems(PolicyData policyData) => new List<TravelerItem>
        {
            new("Hat",1),
            new("SunGlasses",2),
            new("Cream With UV Filter",3),

        };

        public bool IsApplicable(PolicyData policyData) => policyData.Temperature > 25D;
    }
}
