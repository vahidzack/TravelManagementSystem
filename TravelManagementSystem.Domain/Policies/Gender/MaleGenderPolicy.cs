using TravelManagementSystem.Domain.ValueObject;

namespace TravelManagementSystem.Domain.Policies.Gender
{
    internal sealed class MaleGenderPolicy : ITravelerItemPolicy
    {
        public IEnumerable<TravelerItem> GenerateItems(PolicyData policyData) =>
            new List<TravelerItem>
            {new ("laptop",1),
            new ("Drink",2),
            new ("Book",(uint) Math.Ceiling(policyData.Days / 7m)),
            };

        public bool IsApplicable(PolicyData policyData) => policyData.Gender is Consts.Gender.Male;
    }
}
