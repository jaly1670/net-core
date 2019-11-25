using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sansonEdu001.Interfaces
{
    public interface IPricesService
    {
        Task<IActionResult> GetPricesAsync(int productId);
    }
}
