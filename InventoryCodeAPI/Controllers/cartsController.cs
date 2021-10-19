using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventoryCodeAPI.Model;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace InventoryCodeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class cartsController : ControllerBase
    {
        private readonly cartDBContext _context;

        public cartsController(cartDBContext context)
        {
            _context = context;
        }

        // GET: api/carts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<cart>>> Getcarts()
        {
            return await _context.carts.ToListAsync();
        }

        // GET: api/carts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<cart>> Getcart(int id)
        {
            var cart = await _context.carts.FindAsync(id);

            if (cart == null)
            {
                return NotFound();
            }

            return cart;
        }

        // PUT: api/carts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putcart(int id, cart carts)
        {
            if (id != carts.id)
            {
                return BadRequest();
            }

            var ct = await _context.carts.FindAsync(id);
            ct.QTY = carts.QTY;
            //carts.productid = ct.productid;
            //carts.productName = ct.productName;
            //carts.userid = ct.userid;
            //carts.status = ct.status;
            //carts.Price = ct.Price;
            //carts.UDT = DateTime.Now;
            
            _context.Entry(ct).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!cartExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/carts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<cart>> Postcart(cart cart)
        {

            _context.carts.Add(cart);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Getcart", new { id = cart.id }, cart);
        }

        // DELETE: api/carts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletecart(int id)
        {
            var cart = await _context.carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }
            _context.carts.Remove(cart);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool cartExists(int id)
        {
            return _context.carts.Any(e => e.id == id);
        }
    }
}
