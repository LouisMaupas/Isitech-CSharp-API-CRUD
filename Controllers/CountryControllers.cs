using Microsoft.AspNetCore.Mvc;

namespace Api_Web.Controllers;

[ApiController]
[Route("[controller]")]

public class CountryController : ControllerBase
{ 
    private readonly ApplicationDbContext _context;

    public CountryController(ApplicationDbContext dbContext)
    {
        this._context = dbContext;
    }

    // R�cup�re tous les Countries avec les Heroes associ�s 
    // TODO

    // Cr�er un Nouveau Country
    [HttpPost]
    public async Task<ActionResult<List<Country>>> CreateCountry(Country OneCountry)
    {
        _context.Countries.Add(OneCountry);
        await _context.SaveChangesAsync();
        return Ok("Le pays " + OneCountry.Name + " a bien �t� cr�e !");
    }
}