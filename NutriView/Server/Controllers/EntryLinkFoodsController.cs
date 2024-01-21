using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutriView.Server.Data;
using NutriView.Shared.Domain;

namespace NutriView.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntryLinkFoodsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EntryLinkFoodsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EntryLinkFoods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntryLinkFood>>> GetEntryLinkFoods()
        {
          if (_context.EntryLinkFoods == null)
          {
              return NotFound();
          }
            return await _context.EntryLinkFoods.ToListAsync();
        }

        // GET: api/EntryLinkFoods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EntryLinkFood>> GetEntryLinkFood(int id)
        {
          if (_context.EntryLinkFoods == null)
          {
              return NotFound();
          }
            var entryLinkFood = await _context.EntryLinkFoods.FindAsync(id);

            if (entryLinkFood == null)
            {
                return NotFound();
            }

            return entryLinkFood;
        }

        // PUT: api/EntryLinkFoods/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntryLinkFood(int id, EntryLinkFood entryLinkFood)
        {
            if (id != entryLinkFood.Id)
            {
                return BadRequest();
            }

            _context.Entry(entryLinkFood).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntryLinkFoodExists(id))
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

        // POST: api/EntryLinkFoods
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EntryLinkFood>> PostEntryLinkFood(EntryLinkFood entryLinkFood)
        {
          if (_context.EntryLinkFoods == null)
          {
              return Problem("Entity set 'ApplicationDbContext.EntryLinkFoods'  is null.");
          }
            _context.EntryLinkFoods.Add(entryLinkFood);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntryLinkFood", new { id = entryLinkFood.Id }, entryLinkFood);
        }

        // DELETE: api/EntryLinkFoods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntryLinkFood(int id)
        {
            if (_context.EntryLinkFoods == null)
            {
                return NotFound();
            }
            var entryLinkFood = await _context.EntryLinkFoods.FindAsync(id);
            if (entryLinkFood == null)
            {
                return NotFound();
            }

            _context.EntryLinkFoods.Remove(entryLinkFood);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EntryLinkFoodExists(int id)
        {
            return (_context.EntryLinkFoods?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
