using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutriView.Server.IRepository;
using NutriView.Shared.Domain;

[Route("api/[controller]")]
[ApiController]
public class SubscriptionInfosController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public SubscriptionInfosController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SubscriptionInfo>>> GetSubscriptionInfos()
    {
        var subscriptionInfos = await _unitOfWork.SubscriptionInfos.GetAll();
        return Ok(subscriptionInfos);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SubscriptionInfo>> GetSubscriptionInfo(int id)
    {
        var subscriptionInfo = await _unitOfWork.SubscriptionInfos.Get(q => q.Id == id);
        if (subscriptionInfo == null) return NotFound();
        return Ok(subscriptionInfo);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutSubscriptionInfo(int id, SubscriptionInfo subscriptionInfo)
    {
        if (id != subscriptionInfo.Id) return BadRequest();
        _unitOfWork.SubscriptionInfos.Update(subscriptionInfo);

        try { await _unitOfWork.Save(HttpContext); }
        catch (DbUpdateConcurrencyException)
        {
            if (!await SubscriptionInfoExists(id)) return NotFound();
            else throw;
        }
        return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<SubscriptionInfo>> PostSubscriptionInfo(SubscriptionInfo subscriptionInfo)
    {
        await _unitOfWork.SubscriptionInfos.Insert(subscriptionInfo);
        await _unitOfWork.Save(HttpContext);
        return CreatedAtAction("GetSubscriptionInfo", new { id = subscriptionInfo.Id }, subscriptionInfo);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSubscriptionInfo(int id)
    {
        await _unitOfWork.SubscriptionInfos.Delete(id);
        await _unitOfWork.Save(HttpContext);
        return NoContent();
    }

    private async Task<bool> SubscriptionInfoExists(int id)
    {
        var subscriptionInfo = await _unitOfWork.SubscriptionInfos.Get(q => q.Id == id);
        return subscriptionInfo != null;
    }
}
