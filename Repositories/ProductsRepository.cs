﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sansonEdu001.Contexts;
using sansonEdu001.Interfaces;
using sansonEdu001.Models;
using Microsoft.EntityFrameworkCore;

namespace sansonEdu001.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly DefaultContext _context;

        public ProductsRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductAsync(int productId)
        {
            return await _context.Products.Where(p => p.ProductId == productId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> FindProductsAsync(string sku)
        {
            return await _context.Products.Where(p => p.Sku.Contains(sku)).ToListAsync();
        }

        public async Task<Product> DeleteProductAsync(int productId)
        {
            Product product = await GetProductAsync(productId);

            if (product != null)
            {
                _context.Products.Remove(product);

                await _context.SaveChangesAsync();
            }

            return product;
        }
    }

}
