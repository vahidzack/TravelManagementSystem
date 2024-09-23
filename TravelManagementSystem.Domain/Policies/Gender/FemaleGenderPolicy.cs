using TravelManagementSystem.Domain.ValueObject;

namespace TravelManagementSystem.Domain.Policies.Gender
{
    internal sealed class FemaleGenderPolicy : ITravelerItemPolicy
    {
        public IEnumerable<TravelerItem> GenerateItems(PolicyData policyData) =>
            new List<TravelerItem>
            {
                new("LipsTick",1),
                new("Powder",2),
                new("EyeLiner",3),
            };

        public bool IsApplicable(PolicyData policyData) => policyData.Gender is Consts.Gender.Female;

    }
}
