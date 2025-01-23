using CRMApp8.Models.Northwind;

namespace CRMApp8.Northwind
{
    public interface INorthwindService
    {
        Task<List<CustomersType>> GetCustomers();
    }
}
