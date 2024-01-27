using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutriView.Server.IRepository;
using NutriView.Shared.Domain;

[Route("api/[controller]")]
[ApiController]
public class ServiceLinkSubInfosController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public ServiceLinkSubInfosController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ServiceLinkSubInfo>>> GetServiceLinkSubInfos()
    {
        var staffs = await _unitOfWork.ServiceLinkSubInfos.GetAll();
        return Ok(staffs);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceLinkSubInfo>> GetServiceLinkSubInfo(int id)
    {
        var staff = await _unitOfWork.ServiceLinkSubInfos.Get(q => q.Id == id);
        if (staff == null) return NotFound();
        return Ok(staff);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutServiceLinkSubInfo(int id, ServiceLinkSubInfo staff)
    {
        if (id != staff.Id) return BadRequest();
        _unitOfWork.ServiceLinkSubInfos.Update(staff);

        try { await _unitOfWork.Save(HttpContext); }
        catch (DbUpdateConcurrencyException)
        {
            if (!await ServiceLinkSubInfoExists(id)) return NotFound();
            else throw;
        }
        return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<ServiceLinkSubInfo>> PostServiceLinkSubInfo(ServiceLinkSubInfo staff)
    {
        await _unitOfWork.ServiceLinkSubInfos.Insert(staff);
        await _unitOfWork.Save(HttpContext);
        return CreatedAtAction("GetServiceLinkSubInfo", new { id = staff.Id }, staff);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteServiceLinkSubInfo(int id)
    {
        await _unitOfWork.ServiceLinkSubInfos.Delete(id);
        await _unitOfWork.Save(HttpContext);
        return NoContent();
    }

    private async Task<bool> ServiceLinkSubInfoExists(int id)
    {
        var staff = await _unitOfWork.ServiceLinkSubInfos.Get(q => q.Id == id);
        return staff != null;
    }
}
