using TravelManagementSystem.Domain.ValueObject;

namespace TravelManagementSystem.Domain.Policies
{
    public interface ITravelerItemPolicy
    {
        bool IsApplicable(PolicyData policyData);
        IEnumerable<TravelerItem> GenerateItems(PolicyData policyData);

    }
}
