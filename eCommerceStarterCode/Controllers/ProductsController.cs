using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // <baseurl>/api/products
        [HttpGet, Authorize]
        public IActionResult Get()
        {
            var products = _context.Products;
            return Ok(products);
        }

        // POST /api/product
        [HttpPost, Authorize]
        public IActionResult Post([FromBody]Products value)
        {
            _context.Products.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}
