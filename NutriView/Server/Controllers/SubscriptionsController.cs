using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutriView.Server.IRepository;
using NutriView.Shared.Domain;

[Route("api/[controller]")]
[ApiController]
public class SubscriptionsController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public SubscriptionsController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Subscription>>> GetSubscriptions()
    {
        var subscriptions = await _unitOfWork.Subscriptions.GetAll();
        return Ok(subscriptions);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Subscription>> GetSubscription(int id)
    {
        var subscription = await _unitOfWork.Subscriptions.Get(q => q.Id == id);
        if (subscription == null) return NotFound();
        return Ok(subscription);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutSubscription(int id, Subscription subscription)
    {
        if (id != subscription.Id) return BadRequest();
        _unitOfWork.Subscriptions.Update(subscription);

        try { await _unitOfWork.Save(HttpContext); }
        catch (DbUpdateConcurrencyException)
        {
            if (!await SubscriptionExists(id)) return NotFound();
            else throw;
        }
        return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<Subscription>> PostSubscription(Subscription subscription)
    {
        await _unitOfWork.Subscriptions.Insert(subscription);
        await _unitOfWork.Save(HttpContext);
        return CreatedAtAction("GetSubscription", new { id = subscription.Id }, subscription);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSubscription(int id)
    {
        await _unitOfWork.Subscriptions.Delete(id);
        await _unitOfWork.Save(HttpContext);
        return NoContent();
    }

    private async Task<bool> SubscriptionExists(int id)
    {
        var subscription = await _unitOfWork.Subscriptions.Get(q => q.Id == id);
        return subscription != null;
    }
}
