using BestBuyCRUDApp.Models;

namespace BestBuyCRUDApp.Data
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
