using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutriView.Server.IRepository;
using NutriView.Shared.Domain;

[Route("api/[controller]")]
[ApiController]
public class NutritionalQuotasController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public NutritionalQuotasController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<NutritionalQuota>>> GetNutritionalQuotas()
    {
        var nutritionalQuotas = await _unitOfWork.NutritionalQuotas.GetAll();
        return Ok(nutritionalQuotas);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<NutritionalQuota>> GetNutritionalQuota(int id)
    {
        var nutritionalQuota = await _unitOfWork.NutritionalQuotas.Get(q => q.Id == id);
        if (nutritionalQuota == null) return NotFound();
        return Ok(nutritionalQuota);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutNutritionalQuota(int id, NutritionalQuota nutritionalQuota)
    {
        if (id != nutritionalQuota.Id) return BadRequest();
        _unitOfWork.NutritionalQuotas.Update(nutritionalQuota);

        try { await _unitOfWork.Save(HttpContext); }
        catch (DbUpdateConcurrencyException)
        {
            if (!await NutritionalQuotaExists(id)) return NotFound();
            else throw;
        }
        return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<NutritionalQuota>> PostNutritionalQuota(NutritionalQuota nutritionalQuota)
    {
        await _unitOfWork.NutritionalQuotas.Insert(nutritionalQuota);
        await _unitOfWork.Save(HttpContext);
        return CreatedAtAction("GetNutritionalQuota", new { id = nutritionalQuota.Id }, nutritionalQuota);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteNutritionalQuota(int id)
    {
        await _unitOfWork.NutritionalQuotas.Delete(id);
        await _unitOfWork.Save(HttpContext);
        return NoContent();
    }

    private async Task<bool> NutritionalQuotaExists(int id)
    {
        var nutritionalQuota = await _unitOfWork.NutritionalQuotas.Get(q => q.Id == id);
        return nutritionalQuota != null;
    }
}
