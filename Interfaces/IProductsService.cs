using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace sansonEdu001.Interfaces
{
    public interface IProductsService
    {
        Task<IActionResult> GetAllProductsAsync();
        Task<IActionResult> GetProductAsync(int productId);
        Task<IActionResult> FindProductsAsync(string sku);
        Task<IActionResult> DeleteProductAsync(int productId);

    }
}
