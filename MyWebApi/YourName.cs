using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class MyNameController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMyName()
    {
        var myName = new { Name = "Your Name" };
        return Ok(myName);
    }
}