using CRMApp8.Models.ECommerce;

namespace CRMApp8.ECommerce
{
    public class MockECommerceService : IECommerceService
    {
        public Task<List<RevenueType>> GetRevenueList()
        {
            return Task.FromResult<List<RevenueType>>(new());
        }
    }
}
