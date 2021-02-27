using ManufactureItSense.Business.Interfaces.Repositories;
using ManufactureItSense.Business.Interfaces.Services;
using ManufactureItSense.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManufactureItSense.Business.Services
{
    public class InventoryServices : IInventoryService
    {


        private readonly IInventoryRepository _repo;

        public InventoryServices(IInventoryRepository repository)
        {
            _repo = repository;
        }

        public Inventory CreateInventory(Inventory inventory)
        {
            return _repo.CreateInventory(inventory);
        }

        public void UpdateInventory(Inventory inventory)
        {
            _repo.UpdateInventory(inventory);
        }

        public Inventory GetInventoryById(int id)
        {
            return _repo.GetInventoryById(id);
        }

        public async Task<IEnumerable<Inventory>> GetAllInventory()
        {
            return await _repo.GetAllInventory();
        }
    }
}
