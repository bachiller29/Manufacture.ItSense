using ManufactureItSense.Business.Interfaces.Repositories;
using ManufactureItSense.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufactureItSense.Data.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ManufactureItSenseContext _context;

        public ProductsRepository(ManufactureItSenseContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Products CreateProducs(Products products)
        {
            _context.Products.Add(products);
            _context.SaveChanges();
            return products;
        }

        public void UpdateState(Products products)
        {
            _context.Update(products);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Products>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
