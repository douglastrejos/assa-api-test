using assa_api_test.Data;
using assa_api_test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace assa_api_test.Controllers;

[ApiController]
[Route("[controller]")]
public class MarcasAutosController : ControllerBase
{   
    private readonly ILogger<MarcasAutosController> _logger;

    private readonly ApiDbContext _context;

    public MarcasAutosController(ILogger<MarcasAutosController> logger, ApiDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MarcasAutos>>> Get()
    {
        var result = await _context.MarcasAutos.ToListAsync();
        
        return Ok(result);
    }
    
}
