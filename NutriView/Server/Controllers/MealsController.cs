using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutriView.Server.IRepository;
using NutriView.Shared.Domain;

namespace NutriView.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MealsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Meal>>> GetMeals()
        {
            var meals = await _unitOfWork.Meals.GetAll();
            return Ok(meals);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Meal>> GetMeal(int id)
        {
            var meal = await _unitOfWork.Meals.Get(q => q.Id == id);
            if (meal == null) return NotFound();
            return Ok(meal);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeal(int id, Meal meal)
        {
            if (id != meal.Id) return BadRequest();
            _unitOfWork.Meals.Update(meal);

            try { await _unitOfWork.Save(HttpContext); }
            catch (DbUpdateConcurrencyException)
            {
                if (!await MealExists(id)) return NotFound();
                else throw;
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Meal>> PostMeal(Meal meal)
        {
            await _unitOfWork.Meals.Insert(meal);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetMeal", new { id = meal.Id }, meal);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeal(int id)
        {
            await _unitOfWork.Meals.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> MealExists(int id)
        {
            var meal = await _unitOfWork.Meals.Get(q => q.Id == id);
            return meal != null;
        }
    }
}
