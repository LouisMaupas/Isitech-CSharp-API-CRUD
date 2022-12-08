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

    // Récupère tous les Countries avec les Heroes associés 
    // TODO

    // Créer un Nouveau Country
    [HttpPost]
    public async Task<ActionResult<List<Country>>> CreateCountry(Country OneCountry)
    {
        _context.Countries.Add(OneCountry);
        await _context.SaveChangesAsync();
        return Ok("Le pays " + OneCountry.Name + " a bien été crée !");
    }
}