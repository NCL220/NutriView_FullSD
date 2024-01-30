using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutriView.Server.IRepository;
using NutriView.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriView.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GendersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public GendersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gender>>> GetGenders()
        {
            var genders = await _unitOfWork.Genders.GetAll();
            return Ok(genders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Gender>> GetGender(int id)
        {
            var gender = await _unitOfWork.Genders.Get(q => q.Id == id);
            if (gender == null) return NotFound();
            return Ok(gender);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutGender(int id, Gender gender)
        {
            if (id != gender.Id) return BadRequest();
            _unitOfWork.Genders.Update(gender);

            try { await _unitOfWork.Save(HttpContext); }
            catch (DbUpdateConcurrencyException)
            {
                if (!await GenderExists(id)) return NotFound();
                else throw;
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Gender>> PostGender(Gender gender)
        {
            await _unitOfWork.Genders.Insert(gender);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetGender", new { id = gender.Id }, gender);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGender(int id)
        {
            await _unitOfWork.Genders.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> GenderExists(int id)
        {
            var gender = await _unitOfWork.Genders.Get(q => q.Id == id);
            return gender != null;
        }
    }
}
