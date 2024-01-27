using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutriView.Server.IRepository;
using NutriView.Shared.Domain;

[Route("api/[controller]")]
[ApiController]
public class ServicesController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public ServicesController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Service>>> GetServices()
    {
        var services = await _unitOfWork.Services.GetAll();
        return Ok(services);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Service>> GetService(int id)
    {
        var service = await _unitOfWork.Services.Get(q => q.Id == id);
        if (service == null) return NotFound();
        return Ok(service);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutService(int id, Service service)
    {
        if (id != service.Id) return BadRequest();
        _unitOfWork.Services.Update(service);

        try { await _unitOfWork.Save(HttpContext); }
        catch (DbUpdateConcurrencyException)
        {
            if (!await ServiceExists(id)) return NotFound();
            else throw;
        }
        return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<Service>> PostService(Service service)
    {
        await _unitOfWork.Services.Insert(service);
        await _unitOfWork.Save(HttpContext);
        return CreatedAtAction("GetService", new { id = service.Id }, service);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteService(int id)
    {
        await _unitOfWork.Services.Delete(id);
        await _unitOfWork.Save(HttpContext);
        return NoContent();
    }

    private async Task<bool> ServiceExists(int id)
    {
        var service = await _unitOfWork.Services.Get(q => q.Id == id);
        return service != null;
    }
}
