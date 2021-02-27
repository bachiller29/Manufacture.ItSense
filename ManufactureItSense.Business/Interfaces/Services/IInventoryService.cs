using ManufactureItSense.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManufactureItSense.Business.Interfaces.Services
{
    public interface IInventoryService
    {
        Inventory CreateInventory(Inventory inventory);

        void UpdateInventory(Inventory inventory);

        Task<IEnumerable<Inventory>> GetAllInventory();

        Inventory GetInventoryById(int id);
    }
}
