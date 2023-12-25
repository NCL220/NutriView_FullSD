using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutriView.Server.IRepository;
using NutriView.Shared.Domain;

namespace NutriView.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public FoodsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Food>>> GetFoods()
        {
            var foods = await _unitOfWork.Foods.GetAll();
            return Ok(foods);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Food>> GetFood(int id)
        {
            var food = await _unitOfWork.Foods.Get(q => q.Id == id);
            if (food == null) return NotFound();
            return Ok(food);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFood(int id, Food food)
        {
            if (id != food.Id) return BadRequest();
            _unitOfWork.Foods.Update(food);

            try { await _unitOfWork.Save(HttpContext); }
            catch (DbUpdateConcurrencyException)
            {
                if (!await FoodExists(id)) return NotFound();
                else throw;
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Food>> PostFood(Food food)
        {
            await _unitOfWork.Foods.Insert(food);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetFood", new { id = food.Id }, food);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFood(int id)
        {
            await _unitOfWork.Foods.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> FoodExists(int id)
        {
            var food = await _unitOfWork.Foods.Get(q => q.Id == id);
            return food != null;
        }
    }
}
