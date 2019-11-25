using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sansonEdu001.Interfaces;
using sansonEdu001.Models;
using sansonEdu001.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace sansonEdu001.Services
{
    public class PricesService : IPricesService
    {
        private readonly IPricesRepository _pricesRepository;

        public PricesService(IPricesRepository pricesRepository)
        {
            _pricesRepository = pricesRepository;
        }

        public async Task<IActionResult> GetPricesAsync(int productId)
        {
            try
            {
                IEnumerable<Price> pricess = await _pricesRepository.GetPricesAsync(productId);

                if (pricess != null)
                {
                    return new OkObjectResult(pricess.Select(p => new PriceViewModel()
                    {
                        Price = p.Value,
                        Supplier = p.Supplier.Trim()
                    }
                    )
                    .OrderBy(p => p.Price)
                    .ThenBy(p => p.Supplier)
                    );
                }
                else
                {
                    return new NotFoundResult();
                }
            }
            catch
            {
                return new ConflictResult();
            }
        }

    }
}
