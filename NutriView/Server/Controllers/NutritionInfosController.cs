using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutriView.Server.IRepository;
using NutriView.Shared.Domain;

[Route("api/[controller]")]
[ApiController]
public class NutritionInfosController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public NutritionInfosController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<NutritionInfo>>> GetNutritionInfos()
    {
        var nutritionInfos = await _unitOfWork.NutritionInfos.GetAll();
        return Ok(nutritionInfos);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<NutritionInfo>> GetNutritionInfo(int id)
    {
        var nutritionInfo = await _unitOfWork.NutritionInfos.Get(q => q.Id == id);
        if (nutritionInfo == null) return NotFound();
        return Ok(nutritionInfo);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutNutritionInfo(int id, NutritionInfo nutritionInfo)
    {
        if (id != nutritionInfo.Id) return BadRequest();
        _unitOfWork.NutritionInfos.Update(nutritionInfo);

        try { await _unitOfWork.Save(HttpContext); }
        catch (DbUpdateConcurrencyException)
        {
            if (!await NutritionInfoExists(id)) return NotFound();
            else throw;
        }
        return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<NutritionInfo>> PostNutritionInfo(NutritionInfo nutritionInfo)
    {
        await _unitOfWork.NutritionInfos.Insert(nutritionInfo);
        await _unitOfWork.Save(HttpContext);
        return CreatedAtAction("GetNutritionInfo", new { id = nutritionInfo.Id }, nutritionInfo);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteNutritionInfo(int id)
    {
        await _unitOfWork.NutritionInfos.Delete(id);
        await _unitOfWork.Save(HttpContext);
        return NoContent();
    }

    private async Task<bool> NutritionInfoExists(int id)
    {
        var nutritionInfo = await _unitOfWork.NutritionInfos.Get(q => q.Id == id);
        return nutritionInfo != null;
    }
}
