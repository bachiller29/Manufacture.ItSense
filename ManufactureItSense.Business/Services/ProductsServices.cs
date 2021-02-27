using ManufactureItSense.Business.Interfaces.Repositories;
using ManufactureItSense.Business.Interfaces.Services;
using ManufactureItSense.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManufactureItSense.Business.Services
{
    public class ProductsServices : IProductsService
    {
        private readonly IProductsRepository _repo;

        public ProductsServices(IProductsRepository repository)
        {
            _repo = repository;
        }

        public Products CreateProducs(Products products)
        {
            return _repo.CreateProducs(products);
        }
    

        public async Task<IEnumerable<Products>> GetAllProducts()
        {
            return await _repo.GetAllProducts();
        }


        public Products GetProductsById(int id)
        {
            return _repo.GetProductsById(id);
        }

        public void UpdateState(Products products)
        {
            _repo.UpdateState(products);
        }
    }
}
