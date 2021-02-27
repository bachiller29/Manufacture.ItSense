using ManufactureItSense.Business.Interfaces.Repositories;
using ManufactureItSense.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManufactureItSense.Data.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly ManufactureItSenseContext _context;

        public InventoryRepository(ManufactureItSenseContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Inventory CreateInventory(Inventory inventory)
        {
            _context.Inventory.Add(inventory);
            _context.SaveChanges();
            return inventory;
        }

        public void UpdateInventory(Inventory inventory)
        {
            _context.Update(inventory);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Inventory>> GetAllInventory()
        {
            return await _context.Inventory.ToListAsync();
        }

        public Inventory GetInventoryById(int id)
        {
            return _context.Inventory.Find(id);
        }
    }
}
