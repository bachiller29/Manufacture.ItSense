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
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Products>>> GetAllProducts()
        {
            var result = await _productsService.GetAllProducts();
            return result.ToList();
        }
        

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<ActionResult<Products>> PostProducts(Products products)
        {
            var result = _productsService.CreateProducs(products);
            return result;
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducts(int id, Products products)
        {
            if (id != products.ProductId) return BadRequest();

            try
            {
                _productsService.UpdateState(products);
            }
            catch (DbUpdateConcurrencyException)
            {

                throw;
            }

            return NoContent();
        }

    }
}
