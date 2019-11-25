using sansonEdu001.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sansonEdu001.Contexts;
using sansonEdu001.Models;
using Microsoft.EntityFrameworkCore;

namespace sansonEdu001.Repositories
{
    public class PricesRepository : IPricesRepository
    {
        private readonly DefaultContext _context;

    public PricesRepository(DefaultContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Price>> GetPricesAsync(int productId)
    {
        return await _context.Prices.Where(p => p.ProductId == productId).ToListAsync();
    }
}

}
