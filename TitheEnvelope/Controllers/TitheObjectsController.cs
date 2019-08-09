using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TitheEnvelope.Models;

namespace TitheEnvelope.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitheObjectsController : ControllerBase
    {
        private readonly TitheContext _context;

        public TitheObjectsController(TitheContext context)
        {
            _context = context;
        }

        // GET: api/TitheObjects
        [HttpGet]
        public IEnumerable<TitheObject> GetTitheObjects()
        {
            return _context.TitheObjects;
        }

        // GET: api/TitheObjects/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTitheObject([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var titheObject = await _context.TitheObjects.FindAsync(id);

            if (titheObject == null)
            {
                return NotFound();
            }

            return Ok(titheObject);
        }

        // PUT: api/TitheObjects/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTitheObject([FromRoute] long id, [FromBody] TitheObject titheObject)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != titheObject.Id)
            {
                return BadRequest();
            }

            _context.Entry(titheObject).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TitheObjectExists(id))
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

        // POST: api/TitheObjects
        [HttpPost]
        public async Task<IActionResult> PostTitheObject([FromBody] TitheObject titheObject)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TitheObjects.Add(titheObject);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTitheObject", new { id = titheObject.Id }, titheObject);
        }

        // DELETE: api/TitheObjects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTitheObject([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var titheObject = await _context.TitheObjects.FindAsync(id);
            if (titheObject == null)
            {
                return NotFound();
            }

            _context.TitheObjects.Remove(titheObject);
            await _context.SaveChangesAsync();

            return Ok(titheObject);
        }

        private bool TitheObjectExists(long id)
        {
            return _context.TitheObjects.Any(e => e.Id == id);
        }
    }
}