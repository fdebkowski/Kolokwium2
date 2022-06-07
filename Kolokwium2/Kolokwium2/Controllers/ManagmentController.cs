using Kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ManagmentController : ControllerBase
{
    private readonly ManagmentRepository _repository;
    
    public ManagmentController(ManagmentRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult GetAllEvents(bool isDateToPresent)
    {
        var events = _repository.GetAllEvents(isDateToPresent);
        return Ok(events);
    }
}