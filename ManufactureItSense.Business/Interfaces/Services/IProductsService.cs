using ManufactureItSense.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManufactureItSense.Business.Interfaces.Services
{
    public interface IProductsService
    {
        Products CreateProducs(Products products);

        void UpdateState(Products products);

        Task<IEnumerable<Products>> GetAllProducts();

        Products GetProductsById(int id);
    }
}

