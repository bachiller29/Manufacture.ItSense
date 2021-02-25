using ManufactureItSense.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManufactureItSense.Business.Interfaces.Repositories
{
    public interface IProductsRepository
    {
        Products CreateProducs(Products products);

        void UpdateState(Products products);

        Task<IEnumerable<Products>> GetAllProducts();
    }
}
