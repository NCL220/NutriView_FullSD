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
    public class CompaniesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompaniesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompanies()
        {
            var companies = await _unitOfWork.Companies.GetAll();
            return Ok(companies);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompany(int id)
        {
            var company = await _unitOfWork.Companies.Get(q => q.Id == id);
            if (company == null) return NotFound();
            return Ok(company);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, Company company)
        {
            if (id != company.Id) return BadRequest("Company ID mismatch");

            _unitOfWork.Companies.Update(company);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CompanyExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Company>> PostCompany(Company company)
        {
            await _unitOfWork.Companies.Insert(company);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCompany", new { id = company.Id }, company);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            await _unitOfWork.Companies.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> CompanyExists(int id)
        {
            var company = await _unitOfWork.Companies.Get(q => q.Id == id);
            return company != null;
        }
    }
}
