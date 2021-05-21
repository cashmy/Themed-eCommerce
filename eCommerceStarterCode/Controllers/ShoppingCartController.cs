using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;




namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("{userId}"), Authorize]
        public IActionResult GetCurrentUserCart(string userId)
        {
            var userCart = _context.ShoppingCarts
                .Include(uc => uc.Product)
                .Select(uc => new { uc.UserId, uc.ProductId, uc.Product.ProductName, uc.Product.ProductDescription, uc.Quantity, uc.Product.ProductPrice, ExtPrice = uc.Quantity * uc.Product.ProductPrice})
                .ToList();
            return Ok(userCart);
        }

        [HttpPut("{userId}/{productId}"), Authorize]

        public IActionResult Put(string userId, int productId, [FromBody]ShoppingCart value)
        {
            var item = _context.ShoppingCarts.Where(u => (u.UserId == userId && u.ProductId == productId)).SingleOrDefault();
            _context.ShoppingCarts.Remove(item);
            _context.SaveChanges();
            _context.ShoppingCarts.Add(value);
            return Ok(value);

        }

        [HttpPost("{userId}/{productId}"), Authorize]

        public IActionResult Post(string userId, int productId, [FromBody] ShoppingCart value)
        {
            var selectedObject = _context.ShoppingCarts.Where(sc => (sc.UserId == userId && sc.ProductId == productId)).SingleOrDefault();
            if (selectedObject != null)
            {
                selectedObject.Quantity = selectedObject.Quantity + value.Quantity;
                _context.ShoppingCarts.Update(selectedObject);
            } else {
                _context.ShoppingCarts.Add(value);
            }
                _context.SaveChanges();
                return StatusCode(201, selectedObject);
        }

        [HttpDelete("{id}/{productId}"), Authorize ]
        public IActionResult Delete(string id, int productId)
        {

            var item = _context.ShoppingCarts.Where(u => (u.UserId == id && u.ProductId == productId)).SingleOrDefault();
            _context.ShoppingCarts.Remove(item);
            _context.SaveChanges();
            return Ok();
        }




        
    }
}
