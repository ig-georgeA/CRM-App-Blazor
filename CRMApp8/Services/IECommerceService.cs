using CRMApp8.Models.ECommerce;

namespace CRMApp8.ECommerce
{
    public interface IECommerceService
    {
        Task<List<RevenueType>> GetRevenueList();
    }
}
