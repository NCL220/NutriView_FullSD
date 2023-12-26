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
    public class FoodEntriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FoodEntriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FoodEntries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FoodEntry>>> GetFoodEntries()
        {
          if (_context.FoodEntries == null)
          {
              return NotFound();
          }
            return await _context.FoodEntries.ToListAsync();
        }

        // GET: api/FoodEntries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FoodEntry>> GetFoodEntry(int id)
        {
          if (_context.FoodEntries == null)
          {
              return NotFound();
          }
            var foodEntry = await _context.FoodEntries.FindAsync(id);

            if (foodEntry == null)
            {
                return NotFound();
            }

            return foodEntry;
        }

        // PUT: api/FoodEntries/5 daehhaudhahduahdauaudahduahudha
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoodEntry(int id, FoodEntry foodEntry)
        {
            if (id != foodEntry.Id)
            {
                return BadRequest();
            }

            _context.Entry(foodEntry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodEntryExists(id))
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

        // POST: api/FoodEntries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FoodEntry>> PostFoodEntry(FoodEntry foodEntry)
        {
          if (_context.FoodEntries == null)
          {
              return Problem("Entity set 'ApplicationDbContext.FoodEntries'  is null.");
          }
            _context.FoodEntries.Add(foodEntry);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFoodEntry", new { id = foodEntry.Id }, foodEntry);
        }

        // DELETE: api/FoodEntries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFoodEntry(int id)
        {
            if (_context.FoodEntries == null)
            {
                return NotFound();
            }
            var foodEntry = await _context.FoodEntries.FindAsync(id);
            if (foodEntry == null)
            {
                return NotFound();
            }

            _context.FoodEntries.Remove(foodEntry);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FoodEntryExists(int id)
        {
            return (_context.FoodEntries?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
