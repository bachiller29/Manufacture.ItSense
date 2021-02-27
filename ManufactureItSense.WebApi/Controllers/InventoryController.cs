using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManufactureItSense.Business.Interfaces.Services;
using ManufactureItSense.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManufactureItSense.WebApi.Controllers
{
    [Route("api/inventory")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        // GET: api/<InventoryController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inventory>>> GetAllInventory()
        {
            var result = await _inventoryService.GetAllInventory();
            return result.ToList();
        }

        // GET api/<InventoryController>/5
        [HttpGet("{id}")]
        public Inventory GetInventoryByID(int id)
        {
            var result = _inventoryService.GetInventoryById(id);
            return result;
        }

        // POST api/<InventoryController>
        [HttpPost]
        public async Task<ActionResult<Inventory>> PostInventory(Inventory inventory)
        {
            var result = _inventoryService.CreateInventory(inventory);
            return result;
        }

        // PUT api/<InventoryController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventory(int id, Inventory inventory)
        {
            if (id != inventory.InventoryId) return BadRequest();

            try
            {
                _inventoryService.UpdateInventory(inventory);
            }
            catch (DbUpdateConcurrencyException)
            {

                throw;
            }

            return NoContent();
        }

        // DELETE api/<InventoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
