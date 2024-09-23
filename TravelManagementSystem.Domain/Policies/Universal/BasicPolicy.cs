using TravelManagementSystem.Domain.ValueObject;

namespace TravelManagementSystem.Domain.Policies.Universal
{
    internal sealed class BasicPolicy : ITravelerItemPolicy
    {
        private const uint MaximumQuantityOfClothes = 7;
        public bool IsApplicable(PolicyData _) => true;
        public IEnumerable<TravelerItem> GenerateItems(PolicyData policyData) => new List<TravelerItem>
        {
            new("Pans",Math.Min(policyData.Days,MaximumQuantityOfClothes)),
            new("Socks",Math.Min(policyData.Days,MaximumQuantityOfClothes)),
            new("T-shirt",Math.Min(policyData.Days,MaximumQuantityOfClothes)),
            new("Trousers",policyData.Days < 7 ? 1u : 2u),
            new("Shampoo",1),
            new("ToothBrusher",1),
            new("ToothPaste",1),
            new("Towel",1),
            new("Bag pack",1),
            new("Passport",1),
            new("Charger",1),
        };
    }
}
