using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sansonEdu001.Models;

namespace sansonEdu001.Interfaces
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductAsync(int productId);
        Task<IEnumerable<Product>> FindProductsAsync(string sku);
        Task<Product> DeleteProductAsync(int productId);

    }
}
