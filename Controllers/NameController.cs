using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class NameController : ControllerBase
{
    [HttpGet]
    public IActionResult GetName()
    {
        return Ok(new { Name = "Shamak Patel", Age = 24 });
    }
}
